using System;
using System.Windows.Forms;
using Realtor.Services.Abstract;

namespace Realtor.Dialogs
{
    public partial class CompanyEditDialog : Form
    {
        private Company _company;

        public Company Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public CompanyEditDialog(Company company)
        {
            InitializeComponent();

            _company = company;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _cityComboBox.DataSource = GetServiceEx<IDataService>().GetCityes();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            _company.IdCity = (int)_cityComboBox.SelectedValue;
            _company.Name = _nameTextBox.Text;
            _company.Address = _addressTextBox.Text;
            _company.Phone = _phoneTextBox.Text;
            _company.Mail = _emailTextBox.Text;
        }

        private T1 GetServiceEx<T1>()
        {
            return (T1)Site.GetService(typeof(T1));
        }
    }
}