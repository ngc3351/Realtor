using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace Realtor
{
    class DataGridViewHelper
    {
        DataGridView _view;
        Type _type;

        List<DataGridViewColumn> _verticalColumns;
        Dictionary<string, PropertyInfo> _propertiesInfo;

        public Dictionary<string, PropertyInfo> PropertiesInfo
        {
            get
            {
                return _propertiesInfo;
            }
        }

        public DataGridViewHelper(DataGridView view)
        {
            _view = view;
            _propertiesInfo = new Dictionary<string, PropertyInfo>();
            _verticalColumns = new List<DataGridViewColumn>();

            _view.CellPainting += new DataGridViewCellPaintingEventHandler(_view_CellPainting);
            _view.ColumnWidthChanged += new DataGridViewColumnEventHandler(_view_ColumnWidthChanged);

            _view.AutoGenerateColumns = false;
        }

        void _view_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        public void SetupColumns(Type type, Graphics g)
        {
            _view.Columns.Clear();
         
            int columnMaxHeight = 0;            
            PropertyInfo[] props = typeof(ObjSale).GetProperties();

            foreach (PropertyInfo pi in props)
            {
                _propertiesInfo.Add(pi.Name, pi);

                object[] attrs = pi.GetCustomAttributes(typeof (DGVHelperColumnAttribute), false);
                DGVHelperColumnAttribute attr = (attrs.Length != 0)? (attrs[0] as DGVHelperColumnAttribute): null;

                if (attr != null && !attr.Visible)
                    continue;

                DataGridViewColumn col = CreateColumn(pi);

                if (attr != null)
                {
                    if (attr.Vertical)
                    {
                        SizeF size = g.MeasureString(col.HeaderText, _view.RowHeadersDefaultCellStyle.Font, 1000, new StringFormat(StringFormatFlags.DirectionVertical));
                        col.Width = (int)size.Width + 10;

                        if (columnMaxHeight < size.Height + 10)
                            columnMaxHeight = (int)size.Height + 10;

                        _verticalColumns.Add(col);
                    }

                    if (attr.AutoSizeColumnMode != null)
                        col.AutoSizeMode = attr.AutoSizeColumnMode;
                    if (attr.Width > 0)
                        col.Width = attr.Width;
                }
            } 
           
            _view.ColumnHeadersHeight = columnMaxHeight; 
        }

        public void SetupColumns(List<FieldView> list, Graphics g)
        {
            _view.Columns.Clear();
            
            int columnMaxHeight = 0;

            foreach (FieldView fview in list)
            {
                if (fview.FView == 1)
                    continue;

                DataGridViewColumn col = _view.Columns[_view.Columns.Add(fview.FName, fview.FLabel)];
                col.DataPropertyName = fview.FName;
                SizeF size = g.MeasureString(col.HeaderText, _view.RowHeadersDefaultCellStyle.Font, 1000, new StringFormat(StringFormatFlags.DirectionVertical));
                col.Width = (int)size.Width + 10;

                if (columnMaxHeight < size.Height + 10)
                    columnMaxHeight = (int)size.Height + 10;

                _verticalColumns.Add(col);
            }

            _view.ColumnHeadersHeight = columnMaxHeight;
        }

        private DataGridViewColumn CreateColumn(PropertyInfo pi)
        {
            object[] nameAttrs = pi.GetCustomAttributes(typeof(LocalizedDisplayNameAttribute), false);

            DataGridViewColumn col = _view.Columns[_view.Columns.Add(pi.Name, pi.Name)];
            col.DataPropertyName = pi.Name;
            col.Name = pi.Name;
            col.HeaderText = (nameAttrs.Length != 0) ? (nameAttrs[0] as Realtor.LocalizedDisplayNameAttribute).DisplayName : pi.Name;
            
            return col;
        }

        private DataGridViewColumn CreateColumn(string fieldName, string headerText)
        {
            DataGridViewColumn col = _view.Columns[_view.Columns.Add(fieldName, headerText)];
            return col;
        }

        private void _view_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && _verticalColumns.Contains(_view.Columns[e.ColumnIndex]))
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.TranslateTransform(e.CellBounds.Left, e.CellBounds.Bottom);
                e.Graphics.RotateTransform(270);
                e.Graphics.DrawString(e.FormattedValue.ToString(), e.CellStyle.Font, Brushes.Black, 5, 5);
                e.Graphics.ResetTransform();
                e.Handled = true;
            }
        }
    }


}
