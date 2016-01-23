using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Realtor
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(object obj)
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = obj;
        }
    }
}