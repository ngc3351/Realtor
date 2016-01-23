using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Realtor.Controls
{
    public partial class BuildingFeatureNoresident : UserControl
    {
        public BuildingFeatureNoresident(ObjSale obj)
        {
            InitializeComponent();

            objectBindingSource.DataSource = obj;

            _materialComboBox.DataSource = new MaterialValues();
            _floursComboBox.DataSource = new FloursValues();
        }
    }
}
