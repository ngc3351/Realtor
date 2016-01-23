using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Realtor
{
    class MyGrid: DataGridView
    {
        public MyGrid():base()
        {
            CellPainting += new DataGridViewCellPaintingEventHandler(MyGrid_CellPainting);
        }

        int height = 0;
        void MyGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.TranslateTransform(e.CellBounds.Left, e.CellBounds.Bottom);
                e.Graphics.RotateTransform(270);
                e.Graphics.DrawString(e.FormattedValue.ToString(), e.CellStyle.Font, Brushes.Black, 5, 5);
                e.Graphics.ResetTransform();
                e.Handled = true;

                DataGridViewColumn col = Columns[e.ColumnIndex];
                SizeF size = e.Graphics.MeasureString("Column1", RowHeadersDefaultCellStyle.Font, 1000, new StringFormat(StringFormatFlags.DirectionVertical));
                //col.Width = (int)size.Width + 10;
                //Columns[e.ColumnIndex].Width = 

                if (ColumnHeadersHeight < (int)size.Height + 10)
                ColumnHeadersHeight = (int)size.Height + 10;
            }
        }
    }
}
