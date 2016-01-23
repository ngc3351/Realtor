using System;
using System.ComponentModel;
using System.Windows.Forms;
using BLToolkit.Common;
using Realtor.ComponentModel;
using Realtor.Controls;
using Realtor.Dialogs;
using Realtor.Properties;
using Realtor.Services.Abstract;
using System.Collections.Generic;
using System.Xml;

namespace Realtor
{
    public partial class MainForm : Form, ISite, IApplication
    {
        private Control _currentModule;
        private Agent _user;
        private int _idCity;
        List<TSEnumValue> _enumsCache = new List<TSEnumValue>();

        public MainForm()
        {
            InitializeComponent();
            Disposed += mainForm_Disposed;
            Application.ApplicationExit += CmdFileExit;
            LoadEnums();
        }

        #region IApplication Members

        public Agent Agent
        {
            get { return _user; }

            set { _user = value; }
        }

        public string RegKey
        {
            get { return "SN1"; }
        }

        public string IDSetup
        {
            get { return "656ED0B"; }
        }

        public int IDCity
        {
            get { return _idCity; }
            set { _idCity = value; }
        }


        public void ShowModule(IModule module)
        {
            Control ctl = (module as Control);

            if (ctl == null)
                return;

            if (_currentModule == module)
                return;
            _currentModule = ctl;

            //Import menu
            Control[] menus = ctl.Controls.Find("_exportMenuStrip", true);
            foreach (Control menu in menus)
            {
                MenuStrip menuStrip = (menu as MenuStrip);

                if (menuStrip == null)
                    continue;

                for (int i = 0; i < menuStrip.Items.Count; i++)
                    _mainMenuStrip.Items.Insert(1, menuStrip.Items[i]);

                ctl.Controls.Remove(menu);
            }
            //

            panel1.Controls.Clear();
            ctl.Dock = DockStyle.Fill;
            ctl.Site = this;
            panel1.Controls.Add(ctl);
        }

        #endregion

        #region Event handlers

        private static void mainForm_Disposed(object sender, EventArgs e)
        {
            DbRun.Stop();
        }

        #endregion

        #region IServiceProvider implementation

        object IServiceProvider.GetService(Type serviceType)
        {
            if (typeof (IApplication) == serviceType)
                return this;

            if (typeof (IDataService) == serviceType)
                return ServicesProvider.Data;

            if (typeof (IUsersService) == serviceType)
                return ServicesProvider.Users;

            return null;
        }

        IComponent ISite.Component
        {
            get { return this; }
        }

        bool ISite.DesignMode
        {
            get { return false; }
        }

        #endregion

        #region Menu event handlers

        private void CmdFileExit(object sender, EventArgs e)
        {
            DbRun.Stop();
            Close();
        }

        private void CmdShowSettings(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(Settings.Default);
            if (form.ShowDialog() == DialogResult.OK)
                Settings.Default.Save();
        }

        private void CmdUpdateData(object sender, EventArgs e)
        {
            UpdateDialog form = new UpdateDialog();
            form.Site = this;
            form.ShowDialog(this);
        }

        private void CmdClientsManager(object sender, EventArgs e)
        {
            ClientsManager manager = new ClientsManager();
            manager.OwnerId = Agent.IdOwner;
            manager.AgentId = Agent.IdPerson;

            ShowModule(manager);
        }

        #endregion

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            /*
            if (!Settings.Default.Activated)
            {
                ActivationWizard w = new ActivationWizard();
                w.Site = this;
                if (w.ShowDialog() != DialogResult.OK)
                {
                    Close();
                    return;
                }
                Agent = w.Agent;
            }
            */

            //Login
            if (Agent == null)
                using (LogonForm dialog = new LogonForm(this))
                {
                    if (dialog.ShowDialog() != DialogResult.OK || dialog.Agent == null)
                    {
                        Close();
                        return;
                    }

                    Agent = dialog.Agent;
                }
            //

            ShowModule(new ObjectsBrowserEx());
        }

        #region Enums
        
        protected void LoadEnums()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Enums.xml");

            foreach(XmlNode node in doc.SelectNodes("/doc/dic"))
            {
                foreach (string str in node.InnerText.Split(';'))
                {
                    TSEnumValue item = EntityBase<TSEnumValue>.CreateInstance();
                    item.EnumType = node.Attributes["name"].Value;
                    string[] arr = str.Split(':');
                    
                    object key = arr[0].Trim();
                    object value = (arr.Length > 1)? arr[1].Trim(): key;

                    XmlAttribute type;

                    if ((type = node.Attributes["keytype"]) != null)
                        key = StrToObject(type.Value, key.ToString());

                    if ((type = node.Attributes["valuetype"]) != null)
                        value = StrToObject(type.Value, value.ToString());

                    item.Key = key;
                    item.Value = value;
                    _enumsCache.Add(item);
                }
            }
        }

        private object StrToObject(string type, string str)
        {
            switch (type)
            {
                case "System.String":
                    return str;
                case "System.Byte":
                    byte res;
                    Byte.TryParse(str, out res);
                    return res;
                case "System.Int32":
                    int resInt;
                    Int32.TryParse(str, out resInt);
                    return resInt;
                case "System.Windows.Forms.CheckState":
                    return Enum.Parse(typeof (CheckState), str);
            }

            return str;
        }

        public List<TSEnumValue> GetEnumValues(Enums enumType)
        {
            string enumTypeStr = enumType.ToString();
            return _enumsCache.FindAll(delegate(TSEnumValue ev)
            {
                return ev.EnumType.Equals(enumTypeStr);
            });
        }

        public List<TSEnumValue> GetEnumValues(Enums enumType, string defKey, string defValue)
        {
            List<TSEnumValue> list = GetEnumValues(enumType);
            TSEnumValue item = EntityBase<TSEnumValue>.CreateInstance();
            
            if (list.Count > 0)
            {
                item.Key = StrToObject(list[0].Key.GetType().ToString(), defKey);
                item.Value = StrToObject(list[0].Value.GetType().ToString(), defValue);
            }
            else
            {
                item.Key = defKey;
                item.Value = defValue;
            }

            list.Insert(0, item);
            return list;
        }

        public T EnumFindKey<T>(Enums enumType, object value)
        {
            foreach(TSEnumValue ev in GetEnumValues(enumType))
                if (ev.Value.Equals(value))
                    return (T)ev.Key;

            return default(T);
        }

        public T EnumFindValue<T>(Enums enumType, object key)
        {
            foreach (TSEnumValue ev in GetEnumValues(enumType))
                if (ev.Key.Equals(key))
                    return (T)ev.Value;

            return default(T);
        }

        #endregion
    }

    public enum Enums
    {
        Material,
        Series,
        Flour,
        Flours,
        FloursCottage,
        Raspol,
        Flats,
        FlourEx,
        WC,
        Balcony,
        Electricity,
        Hot,
        Water,
        Prava,
        NoresidentObjectType,
        YesNo,
        YesNoUnknow
    }
}