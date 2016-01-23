using System.ComponentModel;
using System.Windows.Forms;

namespace Realtor
{
	/// <summary>
	/// Double Buffered user control - removes flicker during resize operations.
	/// </summary>
	public class FlickerFreeUserControl : UserControl
	{
		public FlickerFreeUserControl()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint |
				ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.UserPaint, true);
		}

		public FlickerFreeUserControl(IContainer container) : this()
		{
			container.Add(this);
		}
	}
}
