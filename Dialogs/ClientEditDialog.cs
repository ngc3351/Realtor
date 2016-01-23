using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLToolkit.Common;

namespace Realtor.Dialogs
{
    public partial class ClientEditDialog : Form
    {
        private readonly Client _notSelected;
        private Client _client;

        protected ClientEditDialog()
        {
            InitializeComponent();

            _statComboBox.DataSource = ClientStatus.GetInstance();
            _typeComboBox.DataSource = ClientType.GetInstance();
        }

        public ClientEditDialog(Client client)
            : this()
        {
            _addButton.Visible = false;

            _namesComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            _namesComboBox.Text = client.Names;
            _namesComboBox.Focus();

            ShowClient(client);
        }

        public ClientEditDialog(List<Client> clients)
            : this()
        {
            _notSelected = EntityBase<Client>.CreateInstance();
            _notSelected.Names = "*КЛИЕНТ НЕ УКАЗАН*";
            clients.Insert(0, _notSelected);

            _namesComboBox.DataSource = clients;
            _namesComboBox.Focus();

            if (clients.Count < 1)
                ShowClient(null);

            SetReadOnly(true);
            //Utils.VisitChildren(this, delegate(Control ctl) {
            //    if (ctl is ComboBox || ctl is TextBox)
            //    Utils.SetControlReadOnly(ctl, true); 
            //});
        }


        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

        public int ClientID
        {
            set 
            {
                _namesComboBox.SelectedValue = value;

                //на случай если клиент был удален
                //и ClientID-а нет в списке
                if (value > 0 && _namesComboBox.SelectedValue == null)
                    _namesComboBox.SelectedValue = 0;
            }
        }


        private void ShowClient(Client client)
        {
            _client = client;
            _clientBindingSource.DataSource = client ?? EntityBase<Client>.CreateInstance();
        }

        private void SetReadOnly(bool readOnly)
        {
            _typeComboBox.Enabled =
            _statComboBox.Enabled = !readOnly;

            _emailTextBox.ReadOnly =
            _phoneTextBox.ReadOnly = 
            _pagerTextBox.ReadOnly = 
            _addressTextBox.ReadOnly = readOnly;
        }

        private void CmdAddClient(object sender, EventArgs e)
        {
            SetReadOnly(false);
            //Utils.VisitChildren(this, delegate(Control ctl) {
            //    if (ctl is ComboBox || ctl is TextBox)
            //    Utils.SetControlReadOnly(ctl, false); 
            //});

            _addButton.Visible = false;

            _namesComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            _namesComboBox.Focus();

            _namesComboBox.DataSource = null;

            ShowClient(EntityBase<Client>.CreateInstance());
        }

        private void namesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowClient((_namesComboBox.SelectedItem as Client));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (_client == _notSelected)
                _client = null;

            if (_client != null)
                _client.Names = _namesComboBox.Text;
        }
    }
}