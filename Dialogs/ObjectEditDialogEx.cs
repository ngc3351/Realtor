using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Realtor.ComponentModel;
using Realtor.Controls;
using Realtor.Properties;
using Realtor.Services.Abstract;
using System.Reflection;

namespace Realtor.Dialogs
{
    public partial class ObjectEditDialogEx : Form
    {
        private readonly ObjSale _obj;
        private readonly ISite _site;
        UserControl buildingFeature;

        public ObjectEditDialogEx(ObjSale obj, ISite site)
        {
            InitializeComponent();

            _obj = obj;
            _site = site;

            objectBindingSource.DataSource = _obj;

            _termСomboBox.DataSource = new TermLeasing();
            _statComboBox.DataSource = new Stat("н/д");
            _forsqСomboBox.DataSource = new ForSQ();

            IDataService data = GetServiceEx<IDataService>();
            _cityComboBox.DataSource = data.GetCityes();
            _rayonComboBox.DataSource = data.GetRayons();
            _streetComboBox.DataSource = data.GetStreets(1);
            _companyComboBox.DataSource = data.GetCompanies();

            UserControl objectFeature = null;

            switch (_obj.IDobject)
            {
                case 1:
                    //_obj.Privat = _obj.Live = true;
                    buildingFeature = new BuildingFeatureFlatEx();
                    //((BuildingFeatureFlatEx)buildingFeature).LoadObject(_obj);
                    objectFeature = new ObjectFeatureFlat();
                    break;
                case 2:
                    //_obj.Live = true;
                    buildingFeature = new BuildingFeatureCottage();
                    objectFeature = new ObjectFeatureCottage();
                    break;
                case 3:
                    buildingFeature = new ObjectFeatureLand();
                    break;
                default:
                    buildingFeature = new BuildingFeatureCottage();
                    objectFeature = new ObjectFeatureNoresident();
                    break;
            }

            buildingFeature.Site = _site;
            panel1.Controls.Add(buildingFeature);
            panel1.Controls[0].Dock = DockStyle.Top;

            if (objectFeature != null)
            {
                objectFeature.Site = _site;
                panel2.Controls.Add(objectFeature);
                panel2.Controls[0].Dock = DockStyle.Top;
            }

            label16.Visible = _forsqСomboBox.Visible = (_obj.IDobject == 3 || _obj.IDobject == 4);
            _termLeasingPanel.Visible = (_obj.IDaction == 3);
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
                if (value != null)
                {
                   
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadObject(_obj);
            Height = tableLayoutPanel1.PreferredSize.Height + panel3.PreferredSize.Height + 25;
            MinimumSize = new Size(MinimumSize.Width, Height);
            tableLayoutPanel1.Height = tableLayoutPanel1.PreferredSize.Height;

            Text = string.Format(Text, _obj.IDobj);

            _okButton.Enabled =
            _clientButton.Enabled = //(_obj.IDowner == GetServiceEx<IApplication>().Agent.IdOwner && (_obj.IDperson == GetServiceEx<IApplication>().Agent.IdPerson));
            (
                //компания совпадает
                _obj.IDowner == Application.Agent.IdOwner
                //агент владелец совпадает
                && (_obj.IDperson == Application.Agent.IdPerson
                //или текущий пользователь с правами админа - ему можно в пределах компании
                || Application.Agent.Priv == "A")
            );

            _clientButton.Image = (!_clientButton.Enabled || _obj.IDclient > 0) ? Resources.id_card1 : Resources.id_card_warning;
        }


        private void CmdClientShow(object sender, EventArgs e)
        {
            IDataService dataService = GetServiceEx<IDataService>();
            ClientEditDialog form = new ClientEditDialog(dataService.GetClients(_obj.IDowner, _obj.IDperson));

            if (_obj.IDclient > 0)
                form.ClientID = _obj.IDclient;

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            if (form.Client == null)
            {
                _clientButton.Image = Resources.id_card_warning;
                _obj.IDclient = 0;
                return;
            }

            Client client = form.Client;

            if (client.IDclient < 1)
            {
                //TODO: не понятно какой IdPerson выбрать для нового клиента 
                //если он создавался и указывался 
                //от агента с правами админа но для объекта 
                //другого агента-пользователя может так:
                client.IDowner = _obj.IDowner;
                client.IDperson = _obj.IDperson;
                client.IDsetup = _obj.IDsetup;
                //а может так
                //client.IDowner = Application.Agent.IdOwner;
                //client.IDperson = Application.Agent.IdPerson;
                //client.IDsetup = Application.IDSetup;

                client.DateReg = DateTime.Now;

                dataService.AddClient(client);
            }

            _obj.IDclient = client.IDclient;
            _clientButton.Image = Resources.id_card1;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _obj.PriceMeter = _obj.Price;

            if (_forsqСomboBox.SelectedValue != "м2" && _obj.SqAll > 0)
                _obj.PriceMeter = _obj.Price/_obj.SqAll;

            SaveObject();
        }


        private T1 GetServiceEx<T1>()
        {
            return (T1)(Site != null
                             ? Site.GetService(typeof(T1))
                             : _site.GetService(typeof(T1)));
        }

        public void LoadObject(ObjSale obj)
        {
            Utils.VisitChildren(this, delegate(Control ctl)
            {
                if (ctl.Tag == null)
                    return;

                object value = typeof(ObjSale).GetProperty(ctl.Tag.ToString()).GetValue(obj, null);
                if (ctl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctl;
                    comboBox.DataSource = Application.GetEnumValues((Enums)Enum.Parse(typeof(Enums), ctl.Tag.ToString()), "", "н/д");
                    comboBox.SelectedValue = value;
                }
                else if (ctl is TextBox)
                {
                    if (value != null)
                    ctl.Text = value.ToString();
                }
                else if (ctl is CheckBox)
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

                PropertyInfo info = typeof(ObjSale).GetProperty(ctl.Tag.ToString());

                if (ctl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctl;
                    info.SetValue(_obj, comboBox.SelectedValue, null);
                }
                else if (ctl is TextBox)
                {
                    
                        if(info.PropertyType == typeof(string))
                        {
                            info.SetValue(_obj, ctl.Text, null);
                        }
                        else if (info.PropertyType == typeof(int))
                        {
                            info.SetValue(_obj, int.Parse(ctl.Text), null);
                        }
                        else if (info.PropertyType == typeof(int?))
                        {
                            info.SetValue(_obj, int.Parse(ctl.Text), null);
                        }
                        else if (info.PropertyType == typeof(byte))
                        {
                            info.SetValue(_obj, byte.Parse(ctl.Text), null);
                        }
                        else if (info.PropertyType == typeof(byte?))
                        {
                            info.SetValue(_obj, byte.Parse(ctl.Text), null);
                        }
                        else if (info.PropertyType == typeof(float))
                        {
                            info.SetValue(_obj, float.Parse(ctl.Text), null);
                        }
                        else if (info.PropertyType == typeof(float?))
                        {
                            if (ctl.Text == string.Empty)
                                info.SetValue(_obj, null, null);
                            else
                            {
                                float res = 0;
                                float.TryParse(ctl.Text, out res);
                                info.SetValue(_obj, res, null);
                            }
                        }
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