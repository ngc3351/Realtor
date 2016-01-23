using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Realtor.ComponentModel;

namespace Realtor.Controls
{
    public partial class BuildingFeatureFlat : UserControl
    {
        ObjSale _obj;
        List<TSEnumValue> _yesno;

        public BuildingFeatureFlat(ObjSale obj)
        {
            InitializeComponent();

            _obj = obj;
            objectBindingSource.DataSource = obj;
        }

        protected IApplication Application
        {
            get { return GetServiceEx<IApplication>(); }
        }

        public override ISite Site
        {
            get { return base.Site; }
            set
            {
                base.Site = value;
                if (value == null) return;

                _materialComboBox.DataSource = Application.GetEnumValues(Enums.Material, string.Empty, "í/ä");
                _yesno = Application.GetEnumValues(Enums.YesNoUnknow);
                _seriesComboBox.DataSource = Application.GetEnumValues(Enums.Series, string.Empty, "í/ä");
                _floursComboBox.DataSource = Application.GetEnumValues(Enums.Flours, "0", "í/ä");
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _liveCheckBox.CheckState = Application.EnumFindKey<CheckState>(Enums.YesNoUnknow, _obj.Live);
            _newCheckBox.CheckState = Application.EnumFindKey<CheckState>(Enums.YesNoUnknow, _obj.New);
        }

        private void _newCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _obj.New = Application.EnumFindValue<string>(Enums.YesNoUnknow, ((CheckBox)sender).CheckState);
        }

        private void _liveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _obj.Live = Application.EnumFindValue<string>(Enums.YesNoUnknow, ((CheckBox)sender).CheckState);
        }

        private T1 GetServiceEx<T1>()
        {
            return (T1)Site.GetService(typeof(T1));
        }
    }
}
