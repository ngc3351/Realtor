using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Realtor.Controls;

namespace Realtor
{
    class MyGrid: DataGridView
    {
        int _headerHeight;
        int _i;

        public MyGrid()
        {
            SetStyle(
                //ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer
                //| ControlStyles.UserPaint
                , true);

            CellPainting += myGrid_CellPainting;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

        private void myGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex <= -1 || e.RowIndex != -1) return;

            if (_i > e.ColumnIndex)
                ColumnHeadersHeight = _headerHeight;

            if (e.ColumnIndex == 0)
                _headerHeight = 0;

            SizeF size = e.Graphics.MeasureString(e.FormattedValue.ToString(), RowHeadersDefaultCellStyle.Font, 1000, new StringFormat(StringFormatFlags.DirectionRightToLeft));

            if (size.Width > e.CellBounds.Width)
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.TranslateTransform(e.CellBounds.Left, e.CellBounds.Bottom);
                e.Graphics.RotateTransform(270);
                e.Graphics.DrawString(e.FormattedValue.ToString(), e.CellStyle.Font, Brushes.Black, 5, 5);
                e.Graphics.ResetTransform();
                e.Handled = true;

                size = e.Graphics.MeasureString(e.FormattedValue.ToString(), RowHeadersDefaultCellStyle.Font, 1000, new StringFormat(StringFormatFlags.DirectionVertical));
                Columns[e.ColumnIndex].MinimumWidth = (int)size.Width + 10;
            }

            if (_headerHeight < (int)size.Height + 10)
                _headerHeight = (int)size.Height + 10;

            _i = e.ColumnIndex;
        }

        public void restoreColumnsSize(string str)
        {
            Dictionary<string, ColumnInfo> colsInfo = parseColumnsInfo(str);
            foreach (string name in colsInfo.Keys)
                if (Columns.Contains(name))
                {
                    Columns[name].Width = colsInfo[name].Width;
                    Columns[name].Visible = colsInfo[name].Visible;
                }
        }

        public string storeColumnsSize(string str)
        {
            Dictionary<string, ColumnInfo> colsInfo = parseColumnsInfo(str);

            foreach (DataGridViewColumn col in Columns)
            {
                if (colsInfo.ContainsKey(col.Name))
                    colsInfo[col.Name].Width = col.Width;
                else
                    colsInfo.Add(col.Name, new ColumnInfo(col.Name, col.Width));

                colsInfo[col.Name].Visible = col.Visible;
            }

            str = string.Empty;

            foreach (string key in colsInfo.Keys)
                str += string.Concat(colsInfo[key].FieldName
                    , ",", colsInfo[key].Width
                    , ",", colsInfo[key].Visible? 1: 0
                    , ";");

            return str;
        }

        private static Dictionary<string, ColumnInfo> parseColumnsInfo(string value)
        {
            Dictionary<string, ColumnInfo> res = new Dictionary<string, ColumnInfo>();
            foreach (string str in value.Split(';'))
            {
                string[] arr = str.Split(',');
                if (arr.Length > 1)
                {
                    res.Add(arr[0], new ColumnInfo(arr[0], int.Parse(arr[1])));

                    if (arr.Length > 2)
                        res[arr[0]].Visible = arr[2] == "1" ? true : false;
                    else
                        res[arr[0]].Visible = true;
                }
            }
            return res;
        }

        private abstract class ColumnInfo_
        {
            public abstract string FieldName { get; set;}
            public abstract int Width { get; set;}
            public abstract bool Visible { get; set;}
        }

        private class ColumnInfo
        {
            private string _filedName;
            private int _width;
            private bool _visible;

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

            public bool Visible
            {
                get { return _visible; }
                set { _visible = value; }
            }
        }
    }
}
