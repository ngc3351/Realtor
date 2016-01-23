using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ITTrust.UI.Common
{
    [ProvideProperty("ButtonBuddy", typeof(ToolStripButton))]
    [ProvideProperty("DropDownButtonBuddy", typeof(ToolStripDropDownButton))]
    [ProvideProperty("SplitButtonBuddy", typeof(ToolStripSplitButton))]
    [ProvideProperty("SeparatorBuddy", typeof(ToolStripSeparator))]
    [ToolboxItem(true)]
    public class MenuBuddyProvider : Component, IExtenderProvider
    {
        private const string PropCategory = "Behavior";
        private const string PropDisplayName = "MenuBuddy";
        private const string PropDescription = "Menu buddy for this button";
        private const string SeparatorPropDescription = "Menu buddy for this separator";

        private readonly Dictionary<ToolStripItem, ToolStripItem> _items
            = new Dictionary<ToolStripItem, ToolStripItem>();

        private readonly Dictionary<ToolStripItem, ToolStripItem> _buddies
            = new Dictionary<ToolStripItem, ToolStripItem>();

        public MenuBuddyProvider()
        {
        }

        public MenuBuddyProvider(IContainer container)
            : this()
        {
            container.Add(this);
        }

        private void SetButtonBuddyInternal(ToolStripItem item, ToolStripItem buddy)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            ToolStripItem oldBuddy;
            if (_buddies.TryGetValue(item, out oldBuddy))
            {
                if (item is ToolStripSplitButton)
                {
                    ToolStripSplitButton splitButton = (ToolStripSplitButton)item;
                    splitButton.ButtonClick -= SyncClick;
                    splitButton.DropDownOpening -= SyncDropDownOpening;
                }
                else if (item is ToolStripDropDownButton)
                {
                    ToolStripDropDownButton dropDownButton = (ToolStripDropDownButton)item;
                    dropDownButton.DropDownOpening -= SyncDropDownOpening;
                }
                else
                    item.Click -= SyncClick;

                oldBuddy.EnabledChanged -= SyncEnabled;
                oldBuddy.AvailableChanged -= SyncAvailable;
                oldBuddy.TextChanged -= SyncTextAndImage;

                if (item is ToolStripButton)
                    ((ToolStripButton)item).CheckStateChanged -= SyncCheckState;

                _buddies.Remove(item);
                _items.Remove(oldBuddy);
            }

            if (buddy == null)
                return;

            _buddies.Add(item, buddy);
            _items.Add(buddy, item);

            if (item is ToolStripSplitButton)
            {
                ToolStripSplitButton splitButton = (ToolStripSplitButton)item;
                splitButton.ButtonClick += SyncClick;
                splitButton.DropDownOpening += SyncDropDownOpening;
            }
            else if (item is ToolStripDropDownButton)
            {
                ToolStripDropDownButton dropDownButton = (ToolStripDropDownButton)item;
                dropDownButton.DropDownOpening += SyncDropDownOpening;
            }
            else
                item.Click += SyncClick;

            if (item is ToolStripButton && buddy is ToolStripMenuItem)
            {
                SyncCheckState(buddy, EventArgs.Empty);
                ((ToolStripMenuItem)buddy).CheckStateChanged += SyncCheckState;
            }

            SyncEnabled(buddy, EventArgs.Empty);
            SyncAvailable(buddy, EventArgs.Empty);
            SyncTextAndImage(buddy, EventArgs.Empty);

            buddy.EnabledChanged += SyncEnabled;
            buddy.AvailableChanged += SyncAvailable;
            buddy.TextChanged += SyncTextAndImage;
        }

        public ToolStripItem GetButtonBuddyInternal(ToolStripItem item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            ToolStripItem buddy;
            return _buddies.TryGetValue(item, out buddy) ? buddy : null;
        }

        public bool CanExtend(object extendee)
        {
            return extendee is ToolStripButton
                || extendee is ToolStripSplitButton
                || extendee is ToolStripDropDownButton
                || extendee is ToolStripSeparator;
        }

        #region Extend props

        [Category.Behavior, DisplayName(PropDisplayName), DefaultValue(null), Description(PropDescription)]
        public ToolStripMenuItem GetButtonBuddy(ToolStripButton button)
        {
            return (ToolStripMenuItem)GetButtonBuddyInternal(button);
        }

        [Category.Behavior, DisplayName(PropDisplayName), DefaultValue(null), Description(PropDescription)]
        public void SetButtonBuddy(ToolStripButton button, ToolStripMenuItem buddy)
        {
            SetButtonBuddyInternal(button, buddy);
        }

        [Category.Behavior, DisplayName(PropDisplayName), DefaultValue(null), Description(PropDescription)]
        public ToolStripMenuItem GetSplitButtonBuddy(ToolStripSplitButton button)
        {
            return (ToolStripMenuItem)GetButtonBuddyInternal(button);
        }

        [Category.Behavior, DisplayName(PropDisplayName), DefaultValue(null), Description(PropDescription)]
        public ToolStripMenuItem GetDropDownButtonBuddy(ToolStripDropDownButton button)
        {
            return (ToolStripMenuItem)GetButtonBuddyInternal(button);
        }

        [Category.Behavior, DisplayName(PropDisplayName), DefaultValue(null), Description(PropDescription)]
        public ToolStripSeparator GetSeparatorBuddy(ToolStripSeparator separator)
        {
            return (ToolStripSeparator)GetButtonBuddyInternal(separator);
        }



        [Category.Behavior, DisplayName(PropDisplayName), DefaultValue(null), Description(PropDescription)]
        public void SetSplitButtonBuddy(ToolStripSplitButton button, ToolStripMenuItem buddy)
        {
            SetButtonBuddyInternal(button, buddy);
        }

        [Category.Behavior, DisplayName(PropDisplayName), DefaultValue(null), Description(PropDescription)]
        public void SetDropDownButtonBuddy(ToolStripDropDownButton button, ToolStripMenuItem buddy)
        {
            SetButtonBuddyInternal(button, buddy);
        }

        [Category.Behavior, DisplayName(PropDisplayName), DefaultValue(null), Description(SeparatorPropDescription)]
        public void SetSeparatorBuddy(ToolStripSeparator separator, ToolStripSeparator buddy)
        {
            SetButtonBuddyInternal(separator, buddy);
        }

        #endregion

        #region Sync

        private void SyncAvailable(object sender, EventArgs e)
        {
            ToolStripItem buddy = (ToolStripItem)sender;
            _items[buddy].Available = buddy.Available;
        }

        private void SyncEnabled(object sender, EventArgs e)
        {
            ToolStripItem buddy = (ToolStripItem)sender;
            _items[buddy].Enabled = buddy.Enabled;
        }

        private void SyncTextAndImage(object sender, EventArgs e)
        {
            ToolStripItem buddy = (ToolStripItem)sender;

            _items[buddy].Text = buddy.Text.Replace("&", string.Empty);
            _items[buddy].Image = buddy.Image;

            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem buddyMenuItem = (ToolStripMenuItem)buddy;
                _items[buddy].ToolTipText = buddyMenuItem.ToolTipText;
                if (buddyMenuItem.ShowShortcutKeys && buddyMenuItem.ShortcutKeys != Keys.None)
                {
                    _items[buddy].ToolTipText += " (" + TypeDescriptor.GetConverter(typeof(Keys)).ConvertToString(buddyMenuItem.ShortcutKeys) + ")";
                }
            }
        }

        private void SyncCheckState(object sender, EventArgs e)
        {
            ToolStripMenuItem buddy = (ToolStripMenuItem)sender;
            ((ToolStripButton)_items[buddy]).CheckState = buddy.CheckState;
        }

        private void SyncClick(object sender, EventArgs e)
        {
            ToolStripItem button = (ToolStripItem)sender;
            _buddies[button].PerformClick();
        }

        private void SyncDropDownOpening(object sender, EventArgs e)
        {
            ToolStripDropDownItem dropDownItem = (ToolStripDropDownItem)sender;
            ToolStripMenuItem buddy = (ToolStripMenuItem)_buddies[dropDownItem];

            dropDownItem.DropDown = buddy.DropDown;
        }

        #endregion
    }
}
