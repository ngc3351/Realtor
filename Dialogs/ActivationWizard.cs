using System;
using System.Windows.Forms;
using BLToolkit.Common;
using Realtor.Services;
using Realtor.Services.Abstract;

namespace Realtor.Dialogs
{
    public partial class ActivationWizard : Form
    {
        private int _ownerId;
        private Company _company;
        private Agent _agent;
        private string _regKey;

        public ActivationWizard()
        {
            InitializeComponent();
        }


        protected ComponentModel.IApplication Application
        {
            get
            {
                return GetServiceEx<Realtor.ComponentModel.IApplication>();
            }
        }

        public int OwnerId
        {
            get { return _ownerId; }
            set { _ownerId = value; }
        }

        public Agent Agent
        {
            get { return _agent; }
            set { _agent = value; }
        }     


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _regKeyTextBox.Focus();
        }


        private void Step1Accomplish()
        {
            if (_regKeyTextBox.Text.Length == 0)
            {
                MessageStep1("¬ведите код активации");
                return;
            }

            _forwardButton.Enabled = false;

            CheckRegkeyAsync(delegate(int ownerId)
                                 {
                                     _ownerId = ownerId;

                                     _forwardButton.Enabled = true;

                                     if (_ownerId <= -1) return;

                                     _regKey = _regKeyTextBox.Text;
                                     _regKeyTextBox.ReadOnly = true;

                                     Step2Begin();
                                 });
        }


        private void Step2Begin()
        {
            _forwardButton.Enabled = false;

            if((_company = GetServiceEx<IDataService>().GetCompany(_ownerId)) != null)
            {
                Step3Begin();
                return;
            }

            _forwardButton.Enabled = true;

            _cityComboBox.DataSource = GetServiceEx<IDataService>().GetCityes();
            wizardControl1.GoTo(wizardPage2);
        }

        private void Step2Accomplish()
        {
            if (_company == null)
            {
                _company = EntityBase<Company>.CreateInstance();
                _company.IdOwner = -1;
            }

            _company.IdCity = (int)_cityComboBox.SelectedValue;
            _company.Name = _nameTextBox.Text;
            _company.Address = _addressTextBox.Text;
            _company.Phone = _phoneTextBox.Text;
            _company.Mail = _emailTextBox.Text;

            if (_company.IdOwner == _ownerId)
            {
                //TODO:
                //GetServiceEx<IDataService>().UpdateCompany(company);
            }
            else
            {
                _company.IdOwner = _ownerId;
                GetServiceEx<IDataService>().CreateCompany(_company);
            }

            Step3Begin();
        }


        private void Step3Begin()
        {
            _forwardButton.Enabled = false;

            if(GetServiceEx<IUsersService>().AdminExists(_ownerId))
            {
                Step4Begin();
                return;
            }

            _forwardButton.Enabled = true;

            wizardControl1.GoTo(wizardPage3);
        }

        private void Step3Accomplish()
        {
            _agent = EntityBase<Agent>.CreateInstance();
            _agent.IdOwner = _ownerId;
            _agent.Priv = "A";
            _agent.Stat = "Y";
            _agent.Self = "N";

            _agent.Family = _loginTextBox.Text;
            _agent.Pass = _passTextBox.Text;

            GetServiceEx<IUsersService>().CreateAgent(_agent);

            Step4Begin();
        }


        private void Step4Begin()
        {
            wizardControl1.GoTo(wizardPage4);
            Step4Accomplish();
        }

        private void Step4Accomplish()
        {
            if (Properties.Settings.Default.Activated)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            _forwardButton.Enabled = false;
            
            MessageStep4("∆дите...");

            CompleteActivationAsync(delegate(bool res)
                                        {
                                            _forwardButton.Enabled = true;

                                            if (!res) return;

                                            _forwardButton.Visible = false;
                                            _cancelButton.DialogResult = DialogResult.OK;
                                            AcceptButton = _cancelButton;

                                            Properties.Settings.Default.Activated = true;
                                            Properties.Settings.Default.Save();

                                            MessageStep4("јктиваци€ завершена");                                            
                                        });
        }


        private void CheckRegkeyAsync(Procedure<int> callBack)
        {
            Function<int> dlg = CheckRegkey;
            dlg.BeginInvoke(MyAsyncCallback<int>, new object[] { dlg, callBack });
        }

        private int CheckRegkey()
        {
            int ownerId = -1;

            WebClient client = new WebClient(Properties.Settings.Default.BaseUrl);

            MessageStep1("∆дите...");

            Response resp = client.SendCommand(new CmdCheckVersion(""));

            if (!resp.OkStatus)
            {
                MessageStep1(resp);
                return ownerId;
            }

            resp = client.SendCommand(new CmdCheckRegKey(_regKeyTextBox.Text
                , CreateSetupId(_regKeyTextBox.Text)));

            MessageStep1(resp);

            if (!resp.OkStatus)
                return ownerId;

            try
            {
                ownerId = int.Parse(resp.GetProperty("ownerId").Value);
            }
            catch (Exception)
            {
                MessageStep1(new ResponseBadResponse());
            }

            return ownerId;
        }


        private void CompleteActivationAsync(Procedure<bool> callBack)
        {
            Function<bool> dlg = CompleteActivation;
            dlg.BeginInvoke(MyAsyncCallback<bool>, new object[] { dlg, callBack });
        }

        private bool CompleteActivation()
        {
            WebClient client = new WebClient(Properties.Settings.Default.BaseUrl);
            Response resp = client.SendCommand(new CmdActivate(_regKey, Application.IDSetup));

            if (resp.OkStatus)
                return true;

            MessageStep4(resp.TryGetPropertyValue("comments"));

            return false;
        }


        private void MessageStep1(string str)
        {
            if (InvokeRequired)
            {
                Procedure<string> dlg = MessageStep1;
                Invoke(dlg, new object[] { str });
                return;
            }

            _messageLabel.Text = str;
        }

        private void MessageStep1(Response resp)
        {
            MessageStep1(resp.TryGetPropertyValue("comments"));
        }

        private void MessageStep4(string str)
        {
            if (InvokeRequired)
            {
                Procedure<string> dlg = MessageStep4;
                Invoke(dlg, new object[] { str });
                return;
            }

            label15.Text = str;
        }


        private string CreateSetupId(string regKey)
        {
            return Application.IDSetup;
        }


        private void _forwardButton_Click(object sender, EventArgs e)
        {
            if (wizardControl1.SelectedPage == wizardPage1)
                Step1Accomplish();
            else if (wizardControl1.SelectedPage == wizardPage2)
                Step2Accomplish();
            else if (wizardControl1.SelectedPage == wizardPage3)
                Step3Accomplish();
            else if (wizardControl1.SelectedPage == wizardPage4)
                Step4Accomplish();
        }

        
        private T1 GetServiceEx<T1>()
        {
            return (T1)Site.GetService(typeof(T1));
        }

        private void MyAsyncCallback<T1>(IAsyncResult ar)
        {
            object[] arr = (object[])ar.AsyncState;
            Function<T1> dlg = (Function<T1>)arr[0];
            Procedure<T1> callback = (Procedure<T1>)arr[1];

            MyInvokeArgs<T1> myInvokeArgs = new MyInvokeArgs<T1>();
            myInvokeArgs.res = dlg.EndInvoke(ar);
            myInvokeArgs.dlg = callback;
            myInvokeArgs.idlg = MyInvoke;
            MyInvoke(myInvokeArgs);
        }

        private void MyInvoke<T1>(MyInvokeArgs<T1> arg)
        {
            if (InvokeRequired)
            {
                Invoke(arg.idlg, new object[] { arg });
                return;
            }

            arg.dlg(arg.res);
        }


        struct MyInvokeArgs<T1>
        {
            public T1 res;
            public Procedure<T1> dlg;
            public Procedure<MyInvokeArgs<T1>> idlg;
        }

        private delegate void Procedure<T1>(T1 arg1);
        private delegate T1 Function<T1>();
    }
}