using System;

namespace ITTrust.UI.Common
{
	public class WizardPageEventArgs : EventArgs
	{
		public WizardPageEventArgs(WizardPage page)
		{
			_page = page;
		}

		private readonly WizardPage _page;
		public           WizardPage  Page
		{
			get { return _page; }
		}
	}
}