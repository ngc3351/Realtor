using System;
using System.Windows.Forms;
using BLToolkit.Common;
using Realtor.ComponentModel;
using Realtor.Dialogs;
using Realtor.Services.Abstract;

namespace Realtor.Controls
{
    public partial class ClientsManager : UserControl, IModule
    {
        private int _agentId;
        private int _ownerId;

        public ClientsManager()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        public ClientsManager(int ownerId, int agentId) : this()
        {
            _ownerId = ownerId;
            _agentId = agentId;
        }


        protected IApplication Application
        {
            get { return GetServiceEx<IApplication>(); }
        }

        public int OwnerId
        {
            get { return _ownerId; }

            set { _ownerId = value; }
        }

        public int AgentId
        {
            get { return _agentId; }

            set { _agentId = value; }
        }

        public Client SelectedClient
        {
            get
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    return null;

                return (Client) dataGridView1.SelectedRows[0].DataBoundItem;
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ShowClients();
        }

        private void ShowClients()
        {
            dataGridView1.DataSource = GetServiceEx<IDataService>().GetClients(OwnerId, AgentId);
        }

        private void ShowEditDialog(Client client)
        {
            if (client == null)
                return;

            ClientEditDialog form = new ClientEditDialog(client);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (client.IDclient > 0)
                    GetServiceEx<IDataService>().UpdateClient(client);
                else
                {
                    client.DateReg = DateTime.Now;
                    GetServiceEx<IDataService>().AddClient(client);
                }
            }

            ShowClients();
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns.IndexOf(Column7))
                e.Value = ClientType.GetInstance().GetValue((string) e.Value);

            if (e.ColumnIndex == dataGridView1.Columns.IndexOf(Column8))
                e.Value = ClientStatus.GetInstance().GetValue((string) e.Value);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEditDialog(SelectedClient);
        }


        private void CmdClientAdd(object sender, EventArgs e)
        {
            Client client = EntityBase<Client>.CreateInstance();
            client.IDsetup = Application.IDSetup;
            client.IDowner = OwnerId;
            client.IDperson = AgentId;

            ShowEditDialog(client);
        }

        private void CmdClientDelete(object sender, EventArgs e)
        {
            if (SelectedClient == null)
                return;

            DialogResult res = MessageBox.Show("Действительно хотите удалить клиента?"
                                               , "Подтверждение"
                                               , MessageBoxButtons.YesNo
                                               , MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            GetServiceEx<IDataService>().DeleteClient(SelectedClient.IDclient);
            ShowClients();
        }

        private void CmdClientEdit(object sender, EventArgs e)
        {
            ShowEditDialog(SelectedClient);
        }

        private void CmdFilterShow(object sender, EventArgs e)
        {
            return;
            panel1.Visible = !panel1.Visible;
        }

        private void CmdObjectsShow(object sender, EventArgs e)
        {
            return;
            panel2.Visible = !panel2.Visible;
        }

        private void CmdContactsShow(object sender, EventArgs e)
        {
        }

        private void CmdPrint(object sender, EventArgs e)
        {
        }


        private T1 GetServiceEx<T1>()
        {
            return (T1) Site.GetService(typeof (T1));
        }
    }
}