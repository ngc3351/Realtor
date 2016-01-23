using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using BLToolkit.Common;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Realtor.Properties;
using Realtor.ComponentModel;
using Realtor.Services.Abstract;

namespace Realtor.Controls
{
    public partial class ObjectsBrowser : UserControl, IModule
    {
        private Dictionary<string, GridColumn> _cols;
        private ObjectActionCriteria _actionCriteria;
        private ObjectTypeCriteria _typeCriteria;

        public ObjectsBrowser()
        {
            InitializeComponent();

            gridView1.CustomDrawColumnHeader += gridView1_CustomDrawColumnHeader;
            gridView1.OptionsView.ColumnAutoWidth = false;

            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridView1.ColumnPanelRowHeight = 150;
            gridView1.ShowCustomizationForm += gridView1_ShowCustomizationForm;

            _showSaleCmd.Tag = new ObjectActionCriteria(1);
            _showLeaseCmd.Tag = new ObjectActionCriteria(3);

            flatToolStripMenuItem.Tag = new ObjectTypeCriteria(1);
            cottegeToolStripMenuItem.Tag = new ObjectTypeCriteria(2);
            landToolStripMenuItem.Tag = new ObjectTypeCriteria(3);
            noresidentToolStripMenuItem.Tag = new ObjectTypeCriteria(4, CompareOperator.AE);

            TypeCriteria = new ObjectTypeCriteria(1);
            ActionCriteria = new ObjectActionCriteria(1);

            flatToolStripMenuItem.Checked =
            _showSaleCmd.Checked = true;
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


        protected override void OnLoad(EventArgs e)
        {
            repositoryItemLookUpEdit1.DataSource = new Prava();
            repositoryItemLookUpEdit2.DataSource = new Flour();
            repositoryItemLookUpEdit3.DataSource = new Flours();
            repositoryItemLookUpEdit4.DataSource = new Flats();
            
            ShowObjects();
        }

        public void ShowObjects()
        {
            ShowObjects(TypeCriteria, ActionCriteria);
        }

        private void ShowObjects(ObjectTypeCriteria type, ObjectActionCriteria action)
        {
            //сохраняем колонки добавленные через дизайнер
            if (_cols == null)
            {
                _cols = new Dictionary<string, GridColumn>();
                for (int k = 0; k < gridView1.Columns.Count; k++)
                {
                    _cols.Add(gridView1.Columns[k].FieldName, gridView1.Columns[k]);
                }
            }
            //

            gridView1.Columns.Clear();

            Dictionary<string, ColumnInfo> info = loadGridColumnsInfo();

            List<FieldView> fviewList = ServicesProvider.Data.GetFView(type.Type, action.Action);
            for (int j = 0; j < fviewList.Count; j++)
            {
                FieldView fview = fviewList[j];
                GridColumn col = (_cols.ContainsKey(fview.FName)) ? _cols[fview.FName] : new GridColumn();

                col.FieldName = fview.FName;
                col.Caption = fview.FLabel;
                col.Name = fview.FLabel;
                col.Visible = true;
                col.VisibleIndex = j;

                if (info.ContainsKey(col.FieldName))
                    col.Width = info[col.FieldName].Width;

                gridView1.Columns.Add(col);
            }

            List<ObjSale> list = ServicesProvider.Data.GetSalesObjects(type, action, 500);
            gridView1.GridControl.DataSource = list;
            
        }

        #region Event handlers

        private int _ci;
        private int _height;

        private void gridView1_ShowCustomizationForm(object sender, EventArgs e)
        {
            gridView1.CustomizationForm.ActiveListBox.Layout += activeListBox_Layout;
            gridView1.CustomizationForm.ActiveListBox.ItemHeight = 30;
        }

        private void gridView1_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != null)
            {
                Rectangle r = e.Info.CaptionRect;
                e.Info.Caption = string.Empty;
                e.Painter.DrawObject(e.Info);

                GraphicsState state = e.Graphics.Save();
                StringFormat sf = new StringFormat();
                sf.Trimming = StringTrimming.EllipsisCharacter;
                sf.FormatFlags |= StringFormatFlags.NoWrap;


                if (!e.Info.CustomizationForm)
                {
                    int ci2 = gridView1.Columns.IndexOf(e.Column);
                    if (ci2 < _ci)
                    {
                        gridView1.ColumnPanelRowHeight = _height;
                        _height = 0;
                    }

                    if (e.Column.VisibleWidth < e.Graphics.MeasureString(e.Column.Caption, e.Appearance.Font).Width + 20)
                    {
                        sf.FormatFlags |= StringFormatFlags.DirectionVertical;

                        if (e.Graphics.MeasureString(e.Column.Caption, e.Appearance.Font).Width + 20 > _height)
                            _height = (int)e.Graphics.MeasureString(e.Column.Caption, e.Appearance.Font).Width + 20;
                    }
                    else
                    {
                        if (e.Graphics.MeasureString(e.Column.Caption, e.Appearance.Font).Height + 5 > _height)
                            _height = (int)e.Graphics.MeasureString(e.Column.Caption, e.Appearance.Font).Height + 5;
                    }
                    _ci = ci2;
                }


                e.Graphics.DrawString(e.Column.Caption, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), r, sf);
                e.Graphics.Restore(state);
            }
            e.Handled = true;
        }

        private void activeListBox_Layout(object sender, LayoutEventArgs e)
        {
            gridView1.CustomizationForm.ActiveListBox.ItemHeight = 30;
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

            ActionCriteria = (ObjectActionCriteria)btn.Tag;
            ShowObjects();
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

            ShowObjects();
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
            obj.DateReg =
            obj.DateUpdate =
            obj.DateUpdate_1 = 
            DateTime.Now;
            obj.IDobject = TypeCriteria.Type;
            obj.IDaction = ActionCriteria.Action;

            Dialogs.ObjectEditDialogEx form = new Dialogs.ObjectEditDialogEx(obj, Site);

            /*ObjectEditDialog form = new ObjectEditDialog(obj);
            form.Site = Site;
            form.DataSource = gridView1.GridControl.DataSource;*/

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            ServicesProvider.Data.InsertSalesObject(obj);
            ShowObjects();
        }

        private void cmdViewObject(object sender, EventArgs e)
        {
            int[] ids = gridView1.GetSelectedRows();

            if (!(ids.Length > 0))
                return;

            ObjSale obj = (ObjSale) gridView1.GetRow(ids[0]);
            Dialogs.ObjectEditDialogEx form = new Dialogs.ObjectEditDialogEx(obj, Site);

            if (form.ShowDialog(this) != DialogResult.OK)
                return;
            
            obj.DateUpdate = DateTime.Now;

            ServicesProvider.Data.UpdateSalesObject(obj);
            ShowObjects();

            /*ObjectEditDialog form = new ObjectEditDialog();
            form.Site = Site;
            form.DataSource = gridView1.GridControl.DataSource;
            form.ShowDialog(this);
            form.NavigatorPosition = gridView1.GetDataSourceRowIndex(ids[0]);*/
        }

        private void cmdDropObject(object sender, EventArgs e)
        {
            int[] ids = gridView1.GetSelectedRows();

            if (!(ids.Length > 0))
                return;

            DialogResult res = MessageBox.Show("Действительно хотите удалить объект?"
                            , "Подтверждение"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            ObjSale obj = (ObjSale)gridView1.GetRow(ids[0]);
            GetServiceEx<IDataService>().DeleteObject(obj.IDobj);

            ShowObjects();
        }

        #endregion

        #region Nested type: ColumnInfo

        private class ColumnInfo
        {
            private string _filedName;
            private int _width;

            public ColumnInfo(string fieldName, int width)
            {
                _filedName = fieldName;
                _width = width;
            }

            public string FieldName
            {
                get { return _filedName; }
                set { _filedName = value; }
            }

            public int Width
            {
                get { return _width; }
                set { _width = value; }
            }
        }

        #endregion


        private void saveGridColumnsInfo()
        {
            Dictionary<string, ColumnInfo> info = loadGridColumnsInfo();

            foreach (GridColumn col in gridView1.Columns)
                if (info.ContainsKey(col.FieldName))
                    info[col.FieldName].Width = col.Width;
                else
                    info.Add(col.FieldName, new ColumnInfo(col.FieldName, col.Width));

            string str = string.Empty;
            foreach (string key in info.Keys)
                str += string.Concat(info[key].FieldName, ",", info[key].Width, ";");

            Settings.Default.GridColumnsWidth = str;
            Settings.Default.Save();
        }

        private static Dictionary<string, ColumnInfo> loadGridColumnsInfo()
        {
            Dictionary<string, ColumnInfo> res = new Dictionary<string, ColumnInfo>();
            foreach (string str in Settings.Default.GridColumnsWidth.Split(';'))
            {
                string[] arr = str.Split(',');
                if (arr.Length > 1)
                    res.Add(arr[0], new ColumnInfo(arr[0], int.Parse(arr[1])));
            }
            return res;
        }

        private T1 GetServiceEx<T1>()
        {
            return (T1)Site.GetService(typeof(T1));
        }
    }
}
