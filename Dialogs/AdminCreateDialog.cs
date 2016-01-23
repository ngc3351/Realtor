using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLToolkit.Common;

namespace Realtor.Dialogs
{
    public partial class AdminCreateDialog : Form
    {
        Agent _agent;

        public AdminCreateDialog(Agent agent)
        {
            InitializeComponent();
            _agent = agent;
        }

        public Agent Agent
        {
            get
            {
                return _agent;
            }
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            _agent.Family = _loginTextBox.Text;
            _agent.Pass = _passTextBox.Text;
        }
    }
}