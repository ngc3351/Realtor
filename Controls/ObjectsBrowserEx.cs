using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using BLToolkit.Common;
using BLToolkit.EditableObjects;
using Realtor.Properties;
using Realtor.ComponentModel;
using Realtor.Services.Abstract;

namespace Realtor.Controls
{
    public partial class ObjectsBrowserEx : UserControl, IModule
    {
        private Dictionary<string, DataGridViewColumn> _cols;
        private ObjectActionCriteria _actionCriteria;
        private ObjectTypeCriteria _typeCriteria;

        private List<CityEntity> _city;
        private List<CityRayon> _rayon;
        private List<CityStreet> _street;

        private Prava _prava;
        private Flour _flour;
        private Flours _flours;
        private Flats _flats;

        readonly FilterPanel _filter;

        int _saleOrLease;
        int _supplyOrDemand;

        public ObjectsBrowserEx()
        {
            InitializeComponent();

            gridView1.AutoGenerateColumns = false;
            gridView1.CellFormatting += gridView1_CellFormatting;
            gridView1.SelectionChanged += new EventHandler(gridView1_SelectionChanged);

            _showSaleCmd.Tag = 1;// new ObjectActionCriteria(1);
            _showLeaseCmd.Tag = 3;// new ObjectActionCriteria(3);

            _supplyToolStripButton.Tag = 0;
            _demandToolStripButton.Tag = 1;

            flatToolStripMenuItem.Tag = new ObjectTypeCriteria(1);
            cottegeToolStripMenuItem.Tag = new ObjectTypeCriteria(2);
            landToolStripMenuItem.Tag = new ObjectTypeCriteria(3);
            noresidentToolStripMenuItem.Tag = new ObjectTypeCriteria(4, CompareOperator.AE);

            TypeCriteria = new ObjectTypeCriteria(1);
            ActionCriteria = new ObjectActionCriteria(1);

            _saleOrLease = 1;
            _supplyOrDemand = 0;

            flatToolStripMenuItem.Checked =
            _supplyToolStripButton.Checked =
            _showSaleCmd.Checked = true;

            _filter = new FilterPanel(this);

            ((ComboBox)_cityToolStripComboBox.Control).DisplayMember = "City";
            ((ComboBox)_cityToolStripComboBox.Control).ValueMember = "IdCity";

            ChangeType += objectsBrowserEx_ChangeType;
            ChangeAction += objectsBrowserEx_ChangeAction;
        }


        public override ISite Site
        {
            get { return base.Site; }
            set
            {
                base.Site = value;
                if (value != null)
                {
                    _filter.Site = value;

                    ((ComboBox)_cityToolStripComboBox.Control).DataSource = GetServiceEx<IDataService>().GetCityes();
                    ((ComboBox)_cityToolStripComboBox.Control).SelectedValue = Application.IDCity;
                }
            }
        }

        protected IApplication Application
        {
            get
            {
                return GetServiceEx<Realtor.ComponentModel.IApplication>();
            }
        }

        public ObjectTypeCriteria TypeCriteria
        {
            get { return _typeCriteria; }

            set { _typeCriteria = value; }
        }

        public ObjectActionCriteria ActionCriteria
        {
            get { return _actionCriteria; }

            set { _actionCriteria = value; }
        }

        public ObjSale SelectedObject
        {
            get 
            {
                DataGridViewSelectedRowCollection ids = gridView1.SelectedRows;

                if (!(ids.Count > 0))
                    return null;

                return (ObjSale)ids[0].DataBoundItem;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            _prava = new Prava();
            _flour = new Flour();
            _flours = new Flours();
            _flats = new Flats();

            _city = GetServiceEx<IDataService>().GetCityes();
            _rayon = GetServiceEx<IDataService>().GetRayons();
            _street = GetServiceEx<IDataService>().GetStreets();

            RefreshColumns();
            ShowObjects();
        }

        public void ShowObjects()
        {
            if (_leftPanel.Visible)
                _filter.ApplyFilter(this);
            else
                ShowObjects(ServicesProvider.Data.GetSalesObjects(Application.IDCity, TypeCriteria, ActionCriteria, 500));
        }

        public void ShowObjects(ObjectSearchCriteria criteria)
        {
            UpdateMenu();
            criteria.ObjectType = TypeCriteria;
            criteria.ObjectAction = ActionCriteria;
            ShowObjects(ServicesProvider.Data.GetSalesObjects(criteria));
        }

        private void ShowObjects(List<ObjSale> list)
        {
            gridView1.DataSource = new EditableList<ObjSale>(list);   
        }

        private void RefreshColumns()
        {
            gridView1.ColumnWidthChanged -= gridView1_ColumnWidthChanged;

            //сохраняем колонки добавленные через дизайнер
            if (_cols == null)
            {
                _cols = new Dictionary<string, DataGridViewColumn>();
                for (int k = 0; k < gridView1.Columns.Count; k++)
                {
                    _cols.Add(gridView1.Columns[k].Name, gridView1.Columns[k]);
                }
            }
            //

            gridView1.Columns.Clear();
            int action = ActionCriteria.Action;
            if (action == 2)
                action = 1;
            if (action == 4)
                action = 3;

            List<FieldView> fviewList = ServicesProvider.Data.GetFView(TypeCriteria.Type, action);
            for (int j = 0; j < fviewList.Count; j++)
            {
                FieldView fview = fviewList[j];
                int i = gridView1.Columns.Add(fview.FName, (fview.FShortLabel != string.Empty) ? fview.FShortLabel : fview.FLabel);
                gridView1.Columns[i].ToolTipText = fview.FLabel;
                gridView1.Columns[i].DataPropertyName = fview.FName;
            }

            RestoreColumns();

            gridView1.ColumnWidthChanged += gridView1_ColumnWidthChanged;
        }

        #region Event handlers

        private void gridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            StoreColumns();
        }

        private void gridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (gridView1.Columns[e.ColumnIndex].DataPropertyName)
            {
                case "DateUpdate":
                    var date = ((System.DateTime)e.Value);
                    e.Value = date.AddYears((date.Month>1? 2015: 2016) - date.Year);
                    break;
                case "Flour":
                    e.Value = _flour.GetValue((int) e.Value);
                    break;
                case "Flours":
                    e.Value = _flours.GetValue((byte)e.Value);
                    break;
                case "Prava":
                    e.Value = _prava.GetValue((byte)e.Value);
                    break;
                case "Flats":
                    e.Value = _flats.GetValue((byte)e.Value);
                    break;
                case "IDcity":
                    CityEntity city = _city.Find(delegate(CityEntity item) { return item.IdCity == (int)e.Value; });
                    e.Value = (city != null) ? city.City : e.Value;
                    break;
                case "IDrayon":
                    CityRayon rayon = _rayon.Find(delegate(CityRayon item) { return item.IdRayon == (int)e.Value; });
                    e.Value = (rayon != null) ? rayon.Rayon : e.Value;
                    break;
                case "IDstreet":
                    CityStreet street = _street.Find(delegate(CityStreet item) { return item.IdStreet == (int)e.Value; });
                    e.Value = (street != null) ? street.Street : e.Value;
                    break;
            }
        }

        private void gridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateMenu();
        }

        private void cityToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Application.IDCity = (int)((ComboBox)_cityToolStripComboBox.Control).SelectedValue;

            RaiseChangeCity();
            ShowObjects();
        }

        private void objectsBrowserEx_ChangeType(object sender, EventArgs e)
        {
            UpdateMenu();
            RefreshColumns();

            if (_columnsSelectToolStripButton.Checked)
                ShowColumnsSelector();

            ShowObjects();
        }

        private void objectsBrowserEx_ChangeAction(object sender, EventArgs e)
        {
            ShowObjects();
        }

        private void columnsSelector_SelectedChanged(object sender, EventArgs e)
        {
            StoreColumns();
        }

        #endregion

        #region Menu event handlers

        private void cmdObjectsChangeAction(object sender, EventArgs e)
        {
            Application.ShowModule(this);

            ToolStripButton btn = (ToolStripButton)sender;
            _showSaleCmd.Checked =
                _showLeaseCmd.Checked = false;

            btn.Checked = true;

            //ActionCriteria = (ObjectActionCriteria)btn.Tag;
            _saleOrLease = (int)btn.Tag;
            ActionCriteria = new ObjectActionCriteria(_saleOrLease + _supplyOrDemand);

            RaiseChangeAction(); 
        }

        private void cmdObjectsChangeType(object sender, EventArgs e)
        {
            Application.ShowModule(this);

            ToolStripMenuItem btn = (ToolStripMenuItem)sender;

            flatToolStripMenuItem.Checked =
            cottegeToolStripMenuItem.Checked =
            landToolStripMenuItem.Checked =
            noresidentToolStripMenuItem.Checked = false;

            btn.Checked = true;

            TypeCriteria = (ObjectTypeCriteria)btn.Tag;

            RaiseChangeType();
        }

        private void demandToolStripButton_Click(object sender, EventArgs e)
        {
            Application.ShowModule(this);

            ToolStripButton btn = (ToolStripButton)sender;

            _supplyToolStripButton.Checked =
            _demandToolStripButton.Checked = false;

            btn.Checked = true;
            
            _supplyOrDemand = (int)btn.Tag;
            ActionCriteria = new ObjectActionCriteria(_saleOrLease + _supplyOrDemand);

            RaiseChangeAction();
        }

        private void supplyToolStripButton_Click(object sender, EventArgs e)
        {
            demandToolStripButton_Click(sender, e);
        }

        private void cmdRefreshObjects(object sender, EventArgs e)
        {
            ShowObjects();
        }

        private void cmdAddObject(object sender, EventArgs e)
        {
            ObjSale obj = EntityBase<ObjSale>.CreateInstance();
            obj.IDobj = string.Format("{0}-{1}", (Guid.NewGuid().ToString()).Substring(0, 12).ToUpper(), Application.IDSetup);
            obj.IDowner = Application.Agent.IdOwner;
            obj.IDperson = Application.Agent.IdPerson;
            obj.IDsetup = Application.IDSetup;
            obj.IDcity = Application.IDCity;
            obj.DateReg =
            obj.DateUpdate =
            obj.DateUpdate_1 = 
            DateTime.Now;
            obj.IDobject = TypeCriteria.Type;
            obj.IDaction = ActionCriteria.Action;

            Dialogs.ObjectEditDialogEx form = new Dialogs.ObjectEditDialogEx(obj, Site);

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            ServicesProvider.Data.InsertSalesObject(obj);
            ShowObjects();
        }

        private void cmdViewObject(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection ids = gridView1.SelectedRows;

            if (!(ids.Count > 0))
                return;

            ObjSale obj = (ObjSale)ids[0].DataBoundItem;
            Dialogs.ObjectEditDialogEx form = new Dialogs.ObjectEditDialogEx(obj, Site);

            if (form.ShowDialog(this) != DialogResult.OK)
                return;
            
            obj.DateUpdate = DateTime.Now;

            ServicesProvider.Data.UpdateSalesObject(obj);
            ShowObjects();
        }

        private void cmdDropObject(object sender, EventArgs e)
        {
            if (SelectedObject == null)
                return;

            DialogResult res = MessageBox.Show("Действительно хотите удалить объект?"
                            , "Подтверждение"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            GetServiceEx<IDataService>().DeleteObject(SelectedObject.IDobj);

            ShowObjects();
        }

        private void cmdShowClient(object sender, EventArgs e)
        {
            if (SelectedObject == null)
                return;

            IDataService service = GetServiceEx<IDataService>();
            Realtor.Dialogs.ClientEditDialog form = new Realtor.Dialogs.ClientEditDialog(
                service.GetClients(SelectedObject.IDowner, SelectedObject.IDperson));

            if (SelectedObject.IDclient > 0)
                form.ClientID = SelectedObject.IDclient;

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            if (form.Client == null)
            {
                SelectedObject.IDclient = 0;
            }
            else
            {
                Client client = form.Client;

                if (client.IDclient < 1)
                {
                    client.IDowner = SelectedObject.IDowner;
                    client.IDperson = SelectedObject.IDperson;
                    client.IDsetup = SelectedObject.IDsetup;
                    client.DateReg = DateTime.Now;

                    service.AddClient(client);
                }

                SelectedObject.IDclient = client.IDclient;
            }

            service.UpdateSalesObject(SelectedObject);
        }

        private void cmdShowFilter(object sender, EventArgs e)
        {
            _leftPanel.Visible = 
            filterToolStripButton.Checked = !filterToolStripButton.Checked;

            UpdateMenu();

            if (_leftPanel.Controls.Count > 0)
                return;

            ShowPane(_leftPanel, _filter);
        }

        private void cmdShowColumnsSelector(object sender, EventArgs e)
        {
            _rightPanel.Visible = 
            _columnsSelectToolStripButton.Checked = !_columnsSelectToolStripButton.Checked;

            if (!_columnsSelectToolStripButton.Checked)
                return;

            ShowColumnsSelector();
        }

        #endregion

        #region Events

        object _changeActionEventKey = new object();

        public event EventHandler ChangeAction
        {
            add
            {
                Events.AddHandler(_changeActionEventKey, value);
            }

            remove
            {
                Events.RemoveHandler(_changeActionEventKey, value);
            }
        }


        object _changeTypeEventKey = new object();

        public event EventHandler ChangeType
        {
            add
            {
                Events.AddHandler(_changeTypeEventKey, value);
            }

            remove
            {
                Events.RemoveHandler(_changeTypeEventKey, value);
            }
        }


        object _changeCityEventKey = new object();

        public event EventHandler ChangeCity
        {
            add
            {
                Events.AddHandler(_changeCityEventKey, value);
            }

            remove
            {
                Events.RemoveHandler(_changeCityEventKey, value);
            }
        }


        private void RaiseChangeAction()
        {
            if (Events[_changeActionEventKey] != null)
                Events[_changeActionEventKey].DynamicInvoke(this, new EventArgs());
        }

        private void RaiseChangeType()
        {
            if (Events[_changeTypeEventKey] != null)
                Events[_changeTypeEventKey].DynamicInvoke(this, new EventArgs());
        }

        private void RaiseChangeCity()
        {
            if (Events[_changeCityEventKey] != null)
                Events[_changeCityEventKey].DynamicInvoke(this, new EventArgs());
        }

        #endregion

        private void ShowColumnsSelector()
        {
            ColumnsSelector selector = new ColumnsSelector(gridView1.Columns);
            selector.SelectedChanged += columnsSelector_SelectedChanged;

            ShowPane(_rightPanel, selector); 
        }

        private void ShowPane(Panel holder, Control pane)
        {
            holder.Controls.Clear();

            holder.Visible =
            holder.AutoSize = true;

            holder.Resize += delegate(object sender, EventArgs e)
            {
                Panel panel = (Panel)sender;

                if (panel.Controls.Count > 0)
                    panel.Controls[0].Height = panel.Height;
            };

            holder.Controls.Add(pane);

            //pane.Height = holder.Height;
        }


        private void StoreColumns()
        {
            string key = string.Concat("GridColumns", (TypeCriteria.Type));
            Settings.Default[key] = gridView1.storeColumnsSize((string)Settings.Default[key]);
            Settings.Default.Save();
        }

        private void RestoreColumns()
        {
            string key = string.Concat("GridColumns", (TypeCriteria.Type));
            gridView1.restoreColumnsSize((string)Settings.Default[key]);
        }

        private void UpdateMenu()
        {
            filterToolStripButton.Image = (_filter.FilterEnabled) ? Resources.warning : Resources.find;
            
            _clientTolStripButton.Enabled = 
            dropObjectToolStripButton.Enabled = (SelectedObject != null 
                //компания совпадает
                && SelectedObject.IDowner == Application.Agent.IdOwner
                //агент владелец совпадает
                && (SelectedObject.IDperson == Application.Agent.IdPerson 
                //или текущий пользователь с правами админа - ему можно в пределах компании
                || Application.Agent.Priv == "A"));
        }

        private T1 GetServiceEx<T1>()
        {
            return (T1)Site.GetService(typeof(T1));
        }
    }
}
