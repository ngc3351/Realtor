using System.Windows.Forms;
using BLToolkit.Patterns;

namespace Realtor
{
    internal static class Utils
    {
        #region VisitChildren, ReadOnly, Enable

        public delegate void VisitChildrenCallback(Control ctl);

        public static void VisitChildren(Control ctl, VisitChildrenCallback callback)
        {
            foreach (Control child in ctl.Controls)
            {
                //if (child.Tag == null)
                    VisitChildren(child, callback);
                //else
                    callback(child);
            }
        }

        public delegate void VisitChildrenWithFlagCallback(Control ctl, bool flag);

        public static void VisitChildren(Control ctl, bool flag, VisitChildrenWithFlagCallback callback)
        {
            foreach (Control child in ctl.Controls)
            {
                if (child.Tag == null)
                    VisitChildren(child, flag, callback);
                else
                    callback(child, flag);
            }
        }

        public static void SetControlReadOnly(Control ctl, bool mode)
        {
            if (ctl is ISupportReadOnly)
                ((ISupportReadOnly)ctl).ReadOnly = mode;
            else if (ctl is DataGridView)
                ((DataGridView)ctl).ReadOnly = mode;
            else if (ctl is TextBoxBase)
                ((TextBoxBase)ctl).ReadOnly = mode;
            else
                ctl.Enabled = !mode;
        }

        public static void ReadOnlyMode(Control ctl, bool mode)
        {
            VisitChildren(ctl, mode, SetControlReadOnly);
        }

        public static void EnableControl(Control ctl, bool enable)
        {
            ctl.Enabled = enable;
        }

        public static void EnablePage(Control ctl, bool enable)
        {
            VisitChildren(ctl, enable, EnableControl);
        }

        #endregion

        [MustImplement(true, false)]
        public interface ISupportReadOnly
        {
            bool ReadOnly { get; set; }

            Control StubControl { get; }
        }
    }
}
