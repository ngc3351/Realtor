using System.ComponentModel;
using System.Windows.Forms;

namespace Realtor
{
	/// <summary>
	/// Double Buffered layout panel - removes flicker during resize operations.
	/// </summary>
	public class FlickerFreeTableLayoutPanel : TableLayoutPanel
	{
		public FlickerFreeTableLayoutPanel()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint |
				ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.UserPaint, true);
		}

		public FlickerFreeTableLayoutPanel(IContainer container) : this()
		{
			container.Add(this);
		}
	}
}
