using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Realtor.ComponentModel;

namespace Realtor.Controls
{
    public class ObjectEditControlBase : UserControl
    {
        private ObjSale _obj;

        public ObjectEditControlBase()
        {
        }

        public ObjectEditControlBase(ISite site)
        {
            Site = site;
        }

        protected IApplication Application
        {
            get { return (IApplication)GetService(typeof(IApplication)); }
        }

        public void LoadObject(ObjSale obj)
        {
            _obj = obj;

            Utils.VisitChildren(this, delegate(Control ctl)
            {
                if(ctl.Tag == null)
                    return;

                object value = typeof(ObjSale).GetProperty(ctl.Tag.ToString()).GetValue(obj, null);
                if(ctl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox) ctl;
                    comboBox.DataSource = Application.GetEnumValues((Enums)Enum.Parse(typeof(Enums), ctl.Tag.ToString()));
                    comboBox.SelectedValue = value;
                }

                else if(ctl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctl;
                    checkBox.CheckState = Application.EnumFindKey<CheckState>(Enums.YesNoUnknow, value);
                }
            });
        }

        public void SaveObject()
        {
            Utils.VisitChildren(this, delegate(Control ctl)
            {
                if (ctl.Tag == null)
                    return;

                PropertyInfo info = typeof (ObjSale).GetProperty(ctl.Tag.ToString());

                if (ctl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctl;
                    info.SetValue(_obj, comboBox.SelectedValue, null);
                }

                else if (ctl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctl;
                    info.SetValue(_obj, Application.EnumFindValue<string>(Enums.YesNoUnknow, checkBox.CheckState), null);
                }
            });
        }
    }
}
