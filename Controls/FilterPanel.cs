using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BLToolkit.Common;
using Realtor.Services.Abstract;
using Realtor.ComponentModel;

namespace Realtor.Controls
{
    public partial class FilterPanel : FlickerFreeUserControl
    {
        private Dictionary<int, bool> _enabled;
        private ObjectsBrowserEx _browser;
        private Dictionary<int, FilterObjectFeature> _features;
        private Dictionary<int, ObjectSearchCriteria> _criteries;
        private YesNo _yesNo;

        public FilterPanel(ObjectsBrowserEx browser)
        {
            InitializeComponent();

            _features = new Dictionary<int, FilterObjectFeature>();
            _criteries = new Dictionary<int, ObjectSearchCriteria>();

            _browser = browser;

            browser_ChangeType(null, null);
            _browser.ChangeType += browser_ChangeType;
            _browser.ChangeAction += browser_ChangeType;
            _browser.ChangeCity += new EventHandler(_browser_ChangeCity);

            _criteriaBindingSource.DataSource = Criteria;
            _materialComboBox.DataSource = new Material();
            _floursComboBox.DataSource = new Flours();
            _term—omboBox.DataSource = new TermLeasing();
            //_forsq—omboBox.DataSource = new ForSQ();
            _statComboBox.DataSource = new Stat();
            _periodComboBox.DataSource = new PeriodCriteria();

            _yesNo = new YesNo(CheckState.Unchecked, string.Empty, "+", string.Empty);

            Utils.VisitChildren(this, delegate(Control ctl)
                                      {
                                          if (ctl.DataBindings.Count == 0)
                                              return;

                                          Binding binding = ctl.DataBindings[0];

                                          System.Reflection.PropertyInfo info = typeof(ObjectSearchCriteria).GetProperty(binding.BindingMemberInfo.BindingMember);
                                          
                                          if (info == null)
                                              return;

                                          object o = info.GetValue(Criteria, null);

                                          if ((o as ICriteria) == null) return;
                                          {
                                              ctl.DataBindings.Remove(binding);
                                              ctl.DataBindings.Add(new Binding(binding.PropertyName, binding.DataSource
                                                                               , string.Concat(binding.BindingMemberInfo.BindingMember, ".Value"), binding.FormattingEnabled
                                                                               , binding.DataSourceUpdateMode, binding.NullValue));
                                          }
                                      });
        }


        public override ISite Site
        {
            get { return base.Site; }
            set
            {
                base.Site = value;
                if (value != null)
                {
                    List<Agent> agents = GetServiceEx<IUsersService>().GetAgents();
                    agents.Insert(0, Agent.CreateInstance());

                    List<Company> companies = GetServiceEx<IDataService>().GetCompanies();
                    companies.Insert(0, Company.CreateInstance());

                    _ownerComboBox.DataSource = companies;
                    _personComboBox.DataSource = agents;

                    LoadCities();
                }
            }
        }

        protected IApplication Application
        {
            get { return GetServiceEx<IApplication>(); }
        }

        public bool FilterEnabled
        {
            get 
            {
                return _enabled != null && _enabled.ContainsKey(ObjectType) && _enabled[ObjectType]; 
            }
        }

        public ObjectSearchCriteria Criteria
        {
            get
            {
                if (!_criteries.ContainsKey(ObjectType))
                {
                    ObjectSearchCriteria criteria = EntityBase<ObjectSearchCriteria>.CreateInstance();
                    criteria.ObjectType = _browser.TypeCriteria;
                    criteria.ObjectAction = _browser.ActionCriteria;
                    _criteries.Add(ObjectType, criteria);
                }

                return _criteries[ObjectType];
            }
        }

        private FilterObjectFeature FeatureControl
        {
            get
            {
                if (!_features.ContainsKey(ObjectType))
                    _features.Add(ObjectType, new FilterObjectFeature(Criteria, ObjectType));

                return _features[ObjectType];
            }
        }

        private int ObjectType
        {
            get
            {
                return _browser.TypeCriteria.Type;
            }
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BindCriteria();
            UpdateMenu();
        }

        public void ApplyFilter(ObjectsBrowserEx browser)
        {
            Criteria.IDcity = Application.IDCity;

            browser.ShowObjects(Criteria);
        }

        public void BindCriteria()
        {
            Criteria.Price.—ompare = CompareOperator.LE;

            _newCheckBox.CheckState = _yesNo.FindKey(Criteria.New);
            _liveCheckBox.CheckState = _yesNo.FindKey(Criteria.Live);
        }

        public void LoadCities()
        {
            IDataService data = GetServiceEx<IDataService>();

            //List<CityEntity> cities = data.GetCityes();
            //cities.Insert(0, CityEntity.CreateInstance());

            List<CityRayon> rayons = data.GetRayons(Application.IDCity);
            rayons.Insert(0, CityRayon.CreateInstance());

            List<CityStreet> streets = data.GetStreets(Application.IDCity);
            streets.Insert(0, CityStreet.CreateInstance());

            //_cityComboBox.DataSource = cities;
            _rayonComboBox.DataSource = rayons;
            _streetComboBox.DataSource = streets;
        }


        private void browser_ChangeType(object sender, EventArgs e)
        {
            //TODO: ‰Û·ÎËÛÂÚÒˇ ‚ Ò‚ÓÈÒÚ‚Â 'public ObjectSearchCriteria Criteria' ÔÂÂ‰ÂÎ‡Ú¸
            Criteria.ObjectType = _browser.TypeCriteria;
            Criteria.ObjectAction = _browser.ActionCriteria;
            //
            _criteriaBindingSource.DataSource = Criteria;
            _criteriaBindingSource.ResetBindings(true);

            int height = groupBox3.Size.Height;
            groupBox3.AutoSize = false;
            groupBox3.Height = height;
            groupBox3.Controls.Clear();

            FilterObjectFeature objectFeature = FeatureControl;
            objectFeature.Dock = DockStyle.Fill;
            objectFeature.AutoSize = true;
            groupBox3.Controls.Add(objectFeature);
            groupBox3.AutoSize = true;

            label7.Visible =
            _statComboBox.Visible = ((ObjectType == 1 || ObjectType == 2) && Criteria.ObjectAction.Action != 3);
        }

        void _browser_ChangeCity(object sender, EventArgs e)
        {
            LoadCities();

            foreach (ObjectSearchCriteria criteria in _criteries.Values)
            {
                criteria.IDcity = Criteria.IDcity;
                criteria.IDrayon = 0;
                criteria.IDstreet = 0;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (_enabled == null)
                _enabled = new Dictionary<int, bool>();

            if (!_enabled.ContainsKey(ObjectType))
                _enabled.Add(ObjectType, true);
            else
                _enabled[ObjectType] = true;

            ApplyFilter(_browser);
            UpdateMenu();
        }

        private void _clearToolStripButton_Click(object sender, EventArgs e)
        {
            if (_enabled != null && _enabled.ContainsKey(ObjectType))
            _enabled[ObjectType] = false;

            UpdateMenu();

            ObjectSearchCriteria criteria = EntityBase<ObjectSearchCriteria>.CreateInstance();
            criteria.ObjectType = _browser.TypeCriteria;
            criteria.ObjectAction = _browser.ActionCriteria;
            _criteries[ObjectType] = criteria;

            _criteriaBindingSource.DataSource = criteria;
            FeatureControl.Criteria = criteria;

            BindCriteria();
            ApplyFilter(_browser);
        }


        private void _newCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Criteria.New = _yesNo.GetValue(((CheckBox)sender).CheckState);
        }

        private void _liveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Criteria.Live = _yesNo.GetValue(((CheckBox)sender).CheckState);
        }

        private void UpdateMenu()
        {
            //_clearToolStripButton.Enabled = FilterEnabled;
        }

        private T1 GetServiceEx<T1>()
        {
            return (T1)Site.GetService(typeof(T1));
        }
    }
}
