using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Realtor.Services.Abstract;

namespace Realtor.Controls
{
    public partial class FilterObjectFeature : FlickerFreeUserControl
    {
        private ObjectSearchCriteria _criteria;
        private YesNo _yesNo;

        public FilterObjectFeature(ObjectSearchCriteria criteria, int type)
        {
            InitializeComponent();

            _criteria = criteria;
            _criteriaBindingSource.DataSource = _criteria;

            _yesNo = new YesNo(CheckState.Unchecked, string.Empty, "+", string.Empty);

            _seriesComboBox.DataSource = new Series();
            _pravaComboBox.DataSource = new Prava();
            _flourComboBox.DataSource = new FlourCriteria();
            _balconyComboBox.DataSource = new Balcony();
            _wcComboBox.DataSource = new WCCriteria();
            _objectTypeComboBox.DataSource = new NoresidentObjectType(true);

            switch (type)
            {
                case 1:
                    _electricityheckBox.Visible =
                    _waterCheckBox.Visible =
                    _heatCheckBox.Visible =
                    _mebel2CheckBox.Visible =
                    _pravaLabel.Visible =
                    _pravaComboBox.Visible =
                    _sqLandLabel.Visible =
                    _sqLandTextBox.Visible =
                    _objectTypeLabel.Visible =
                    _objectTypeComboBox.Visible = false;

                    break;
                case 2:
                    _seriesLabel.Visible =
                    _seriesComboBox.Visible =
                    _flourLabel.Visible =
                    _flourComboBox.Visible =
                    _electricityheckBox.Visible =
                    _waterCheckBox.Visible =
                    _heatCheckBox.Visible =
                    _mebel2CheckBox.Visible =                   
                    label5.Visible =
                    _sqKitchTextBox.Visible =
                    _objectTypeLabel.Visible =
                    _objectTypeComboBox.Visible =
                    _balconyLabel.Visible =
                    _balconyComboBox.Visible = false;
                    break;
                case 3:
                    Utils.VisitChildren(tableLayoutPanel1, delegate(Control ctl)
                    {
                        ctl.Visible = false;
                    });
                    _sqLandLabel.Visible =
                    _sqLandTextBox.Visible =
                    _pravaLabel.Visible =
                    _pravaComboBox.Visible = true;
                    break;
                default:
                    _seriesLabel.Visible =
                    _seriesComboBox.Visible =
                    _flourLabel.Visible =
                    _flourComboBox.Visible =
                    _balconyLabel.Visible =
                    _balconyComboBox.Visible =
                    label1.Visible =
                    _flatsTextBox.Visible =
                    label12.Visible =
                    _sqHomeTextBox.Visible =
                    label5.Visible =
                    _sqKitchTextBox.Visible =
                    label8.Visible =
                    _wcComboBox.Visible = false;
                    break;
            }

            Utils.VisitChildren(this, delegate(Control ctl)
                                                  {
                                                      if (ctl.DataBindings.Count == 0)
                                                          return;

                                                      Binding binding = ctl.DataBindings[0];

                                                      object o = typeof(ObjectSearchCriteria).GetProperty(binding.BindingMemberInfo.BindingMember).GetValue(_criteria, null);

                                                      if ((o as ICriteria) == null) return;
                                                      {
                                                          ctl.DataBindings.Remove(binding);
                                                          ctl.DataBindings.Add(new Binding(binding.PropertyName, binding.DataSource
                                                                                           , string.Concat(binding.BindingMemberInfo.BindingMember, ".Value"), binding.FormattingEnabled
                                                                                           , binding.DataSourceUpdateMode, binding.NullValue));
                                                      }
                                                  });
        }


        public ObjectSearchCriteria Criteria
        {
            get
            {
                return _criteria;
            }

            set
            {
                _criteria = value;
                _criteriaBindingSource.DataSource = _criteria;
                BindCriteria();
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BindCriteria();
        }

        public void BindCriteria()
        {
            _criteria.SqAll.Ñompare = CompareOperator.AE;
            _criteria.SqHome.Ñompare = CompareOperator.AE;
            _criteria.SqKitch.Ñompare = CompareOperator.AE;
            _criteria.SqLand.Ñompare = CompareOperator.AE;

            _mebelCheckBox.CheckState = _yesNo.FindKey(_criteria.Mebel);
            _phoneCheckBox.CheckState = _yesNo.FindKey(_criteria.Phone);
            _waterCheckBox.Checked = WaterCriteria.GetInstance().FindKey(_criteria.Water);
            _heatCheckBox.Checked = WaterCriteria.GetInstance().FindKey(_criteria.Hot);
            _electricityheckBox.Checked = WaterCriteria.GetInstance().FindKey(_criteria.Electricity);
        }

        private void electricityheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _criteria.Electricity = WaterCriteria.GetInstance().GetValue(((CheckBox)sender).Checked);
        }

        private void waterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _criteria.Water = WaterCriteria.GetInstance().GetValue(((CheckBox)sender).Checked);
        }

        private void heatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _criteria.Hot = WaterCriteria.GetInstance().GetValue(((CheckBox)sender).Checked);
        }

        private void phoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _criteria.Phone = _yesNo.GetValue(((CheckBox)sender).CheckState);
        }

        private void mebelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _criteria.Mebel = _yesNo.GetValue(((CheckBox)sender).CheckState);
        }

        private void mebel2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //_criteria.Electricity = _yesNo.GetValue(((CheckBox)sender).CheckState);
        }
    }
}
