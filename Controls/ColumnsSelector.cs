using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Realtor.Controls
{
    public partial class ColumnsSelector : UserControl
    {
        List<CheckBox> _checkBoxs = new List<CheckBox>();

        public ColumnsSelector()
        {
            InitializeComponent();
        }

        public ColumnsSelector(DataGridViewColumnCollection columns)
            : this()
        {
            ShowColumns(columns);
        }

        private void ShowColumns(DataGridViewColumnCollection columns)
        {
            _checkBoxs.Clear();

            foreach (DataGridViewColumn col in columns)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Dock = DockStyle.Top;
                checkBox.Text = col.ToolTipText;
                checkBox.Tag = col;
                checkBox.Checked = col.Visible;
                _checkBoxs.Add(checkBox);
                checkBox.CheckedChanged += checkBox_CheckedChanged;
            }

            _checkBoxs.Reverse();
            groupBox1.Controls.AddRange(_checkBoxs.ToArray());
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = ((CheckBox) sender);
            ((DataGridViewColumn)checkBox.Tag).Visible = checkBox.Checked;

            RaiseSelectedChanged();
        }


        object _selectedChangedEventKey = new object();

        public event EventHandler SelectedChanged
        {
            add
            {
                Events.AddHandler(_selectedChangedEventKey, value);
            }

            remove
            {
                Events.RemoveHandler(_selectedChangedEventKey, value);
            }
        }

        private void RaiseSelectedChanged()
        {
            if (Events[_selectedChangedEventKey] != null)
                Events[_selectedChangedEventKey].DynamicInvoke(this, new EventArgs());
        }
    }
}
