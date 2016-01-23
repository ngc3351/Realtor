using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using ITTrust.UI.Common;

namespace Realtor
{
    //[ProvideProperty("Vertical", typeof(DataGridViewColumn))]
    [ProvideProperty("Vertical", typeof(DataGridView))]
    [ToolboxItem(true)]
    public class DataGridViewColumnProvider : Component, IExtenderProvider
    {
        
        public bool CanExtend(object extendee)
        {
            return extendee is DataGridViewColumn
                || extendee is DataGridView;
        }

        [Category.Behavior, DisplayName("Vertical"), DefaultValue(false), Description("Vertical")]
        public DataGridViewColumnCollection GetVertical(DataGridView grid)
        {
            return grid.Columns;
        }

        [Category.Behavior, DisplayName("Vertical"), DefaultValue(false), Description("Vertical")]
        public void SetVertical(DataGridView button, DataGridViewColumnCollection col)
        {
        }
        
        /*
        [Category.Behavior, DisplayName("Vertical"), DefaultValue(false), Description("Vertical")]
        public bool GetVertical(DataGridViewColumn button)
        {
            return true;
        }

        [Category.Behavior, DisplayName("Vertical"), DefaultValue(false), Description("Vertical")]
        public void SetVertical(DataGridViewColumn button, bool sdf)
        {
        }*/
        
    }
}
