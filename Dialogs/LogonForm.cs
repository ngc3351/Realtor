using System;
using System.ComponentModel;
using System.Windows.Forms;
using Realtor.Services.Abstract;

namespace Realtor.Dialogs
{
    public partial class LogonForm : Form
    {
        private readonly ISite _site;
        private Agent _agent;

        public LogonForm(ISite site)
        {
            InitializeComponent();

            _site = site;
            _loginComboBox.DataSource = GetServiceEx<IUsersService>().GetAgents();

            versionLabel.Text = string.Format("v{0}", Application.ProductVersion);
        }

        public Agent Agent
        {
            get { return _agent; }
        }


        private Agent checkAgent()
        {
            return GetServiceEx<IUsersService>().GetAgent(_loginComboBox.Text, _passTextBox.Text);
        }

        protected override void OnClosing(CancelEventArgs cea)
        {
            base.OnClosing(cea);

            if ((DialogResult != DialogResult.OK))
                return;

            Cursor = Cursors.WaitCursor;
            _errorLabel.Visible = false;

            try
            {
                _agent = checkAgent();

                if (_agent == null)
                    cea.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.GetBaseException().Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                cea.Cancel = true;
            }

            _errorLabel.Visible = (_agent == null);
            Cursor = Cursors.Default;
        }


        private T1 GetServiceEx<T1>()
        {
            return (T1) (Site != null
                             ? Site.GetService(typeof (T1))
                             : _site.GetService(typeof (T1)));
        }
    }
}