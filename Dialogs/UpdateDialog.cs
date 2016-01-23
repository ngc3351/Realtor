using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MyDownloader.Core;
using MyDownloader.Extension.SpeedLimit;
using Realtor.ComponentModel;
using Realtor.Services;
using Realtor.Services.Abstract;
using Settings=Realtor.Properties.Settings;

namespace Realtor.Dialogs
{
    public partial class UpdateDialog : Form
    {
        #region Delegates

        public delegate void Procedure();

        public delegate void Procedure<T1>(T1 arg1);

        public delegate void Procedure<T1, T2>(T1 arg1, T2 arg2);

        #endregion

        protected readonly string _baseUrl;

        public UpdateDialog()
        {
            InitializeComponent();
            _baseUrl = Settings.Default.BaseUrl;
        }

        protected IApplication Application
        {
            get { return GetServiceEx<IApplication>(); }
        }


        private void DoUpdate()
        {
            WebClient client = new WebClient(_baseUrl);
            client.OnResponse += client_OnResponse;

            MessageWrite("Проверка версии...");

            Response resp = client.SendCommand(new CmdCheckVersion("1.0.0.1"));

            MessageWriteLine(resp);

            if (!resp.OkStatus)
                return;

            MessageWriteLine();
            MessageWriteLine("Авторизация...");

            resp = client.SendCommand(new CmdLogin(Application.RegKey, Application.IDSetup));

            MessageWriteLine(resp);

            if (!resp.OkStatus)
                return;

            MessageWriteLine();
            MessageWriteLine("Проверка наличия новых объектов на сервере...");

            resp = client.SendCommand(new CmdCheckLastDateDownload(DateTime.Now));

            MessageWriteLine(resp);

            if (!resp.OkStatus)
                return;

            if (resp.TryGetPropertyValue("count") != "0")
            {
                MessageWriteLine();
                MessageWriteLine("Запрос данных...");

                resp = client.SendCommand(new CmdDownload(DateTime.Now));

                MessageWriteLine(resp);

                if (resp.TryGetPropertyValue("status") != "ok")
                    return;

                string file = DownloadFile(resp.TryGetPropertyValue("file"));

                MessageWriteLine("Обновление...");
                LoadUpdates(file);
                MessageWrite("завершено");
            }

            MessageWriteLine();
            MessageWriteLine("Проверка наличия новых объектов в вашей БД за прошедший период...");

            resp = client.SendCommand(new CmdCheckLastDateUpload());

            MessageWriteLine(resp);

            DateTime lastDateUload = DateTime.MinValue;
            DateTime.TryParse(resp.TryGetPropertyValue("date"), out lastDateUload);
            List<ObjSale> list = GetServiceEx<IDataService>().GetSalesObjects(Application.IDSetup, lastDateUload);

            if (list.Count == 0)
            {
                MessageWriteLine("Новых данных нет");
            }
            else
            {
                MessageWriteLine();
                MessageWriteLine("Отправка новых данных на сервер...");

                resp =
                    client.SendCommand(new CmdUpload(DateTime.Now.ToUniversalTime(),
                                                     Services.Utils.Serialize(list).InnerXml));

                MessageWriteLine(resp);

                if (!resp.OkStatus)
                    return;
            }
        }

        private void UpdateAsync(Procedure callBack)
        {
            Procedure dlg = DoUpdate;
            dlg.BeginInvoke(Done, new object[] {dlg, callBack});
        }

        private void UpdateDone()
        {
            if (InvokeRequired)
            {
                Procedure dlg = UpdateDone;
                Invoke(dlg, null);
                return;
            }

            _cancelButton.Enabled = true;
        }


        private string DownloadFile(string url)
        {
            string filename = string.Concat(AppDomain.CurrentDomain.BaseDirectory
                                            , "exchange"
                                            , Path.DirectorySeparatorChar
                                            , Path.GetFileName(url));

            DownloadFile(url, filename);
            return filename;
        }

        private void DownloadFile(string url, string path)
        {
            MessageWriteLine("Приступаю к загрузке...");
            SpeedLimitExtension se = new SpeedLimitExtension(new SpeedLimitParameters());
            se.Parameters.Enabled = true;
            se.SetMaxRateTemp(100);
            ResourceLocation l = ResourceLocation.FromURL(url);
            l.ProtocolProviderType =
                "MyDownloader.Extension.Protocols.HttpProtocolProvider, MyDownloader.Extension, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";

            Downloader downloader = new Downloader(l, null, path, 1);
            downloader.Start();

            while (downloader.State != DownloaderState.Ended &&
                   downloader.State != DownloaderState.EndedWithError)
            {
                UpdateProgressInfo(downloader);
                Thread.Sleep(1000);
            }

            UpdateProgressInfo(downloader);

            MessageWrite(string.Format("получено {0} кБ", downloader.Transfered/1000));
        }

        private void UpdateProgressInfo(Downloader downloader)
        {
            if (InvokeRequired)
            {
                Procedure<Downloader> dlg = UpdateProgressInfo;
                Invoke(dlg, new object[] {downloader});
                return;
            }

            if (downloader.State == DownloaderState.Working)
            {
                label1.Text = string.Format("Получено {0} из {1} кБ", downloader.Transfered/1000,
                                            downloader.FileSize/1000);
                label2.Text = string.Format("Осталось времени: {0}", downloader.Left);

                panel1.Visible = true;
                progressBar1.Value = (int) downloader.Progress;
            }
            else
                panel1.Visible = false;
        }


        private void LoadUpdates(string file)
        {
            List<ObjSale> list = Services.Utils.Deserialize<ObjSale>(File.ReadAllText(file));

            foreach (ObjSale obj in list)
            {
                obj.DateReg = obj.DateReg.ToLocalTime();
                obj.DateUpdate = obj.DateUpdate.ToLocalTime();
            }

            ServicesProvider.Data.InsertSalesObjects(list);
            File.Delete(file);
        }


        private void MessagesClear()
        {
            _messagesTextBox.Text = string.Empty;
        }

        private void MessageWrite(string str)
        {
            if (InvokeRequired)
            {
                Procedure<string> dlg = MessageWrite;
                Invoke(dlg, new object[] {str});
                return;
            }

            _messagesTextBox.Text += str;
        }

        private void MessageWriteLine(string str)
        {
            if (InvokeRequired)
            {
                Procedure<string> dlg = MessageWriteLine;
                Invoke(dlg, new object[] {str});
                return;
            }

            MessageWrite("\r\n" + str);
        }

        private void MessageWriteLine()
        {
            if (InvokeRequired)
            {
                Procedure dlg = MessageWriteLine;
                Invoke(dlg, new object[] {});
                return;
            }

            MessageWrite("\r\n");
        }

        private void MessageWriteLine(Response resp)
        {
            MessageWriteLine(string.Format("{0} > {1}",
                                           resp.TryGetPropertyValue("server"),
                                           resp.TryGetPropertyValue("comments")
                                 ));
        }


        private void cmdUpdate(object sender, EventArgs e)
        {
            MessagesClear();

            _cancelButton.Enabled = false;

            UpdateAsync(UpdateDone);
        }

        private void cmdCancel(object sender, EventArgs e)
        {
        }


        private void client_OnResponse(string str)
        {
            //_messagesTextBox.Text += str + "\r\n";
        }

        private T1 GetServiceEx<T1>()
        {
            return (T1) Site.GetService(typeof (T1));
        }


        private static void Done(IAsyncResult ar)
        {
            object[] arr = (object[]) ar.AsyncState;
            Procedure dlg = (Procedure) arr[0];
            Procedure callback = (Procedure) arr[1];
            dlg.EndInvoke(ar);
            callback();
        }

        #region Nested type: SpeedLimitParameters

        public class SpeedLimitParameters : ISpeedLimitParameters
        {
            #region ISpeedLimitParameters Members

            public bool Enabled
            {
                get { return true; }
                set { }
            }

            public double MaxRate
            {
                get { return 100; }
                set { }
            }

            public event PropertyChangedEventHandler ParameterChanged
            {
                add { }
                remove { }
            }

            #endregion
        }

        #endregion
    }
}