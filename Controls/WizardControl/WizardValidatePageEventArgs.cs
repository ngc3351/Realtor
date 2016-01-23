using System.Windows.Forms;

namespace ITTrust.UI.Common
{
	public class WizardValidatePageEventArgs : WizardPageEventArgs
	{
		#region .ctor/.dtor

		public WizardValidatePageEventArgs(WizardPage page, bool thisPageOnly) : base(page)
		{
			_thisPageOnly = thisPageOnly;
			_valid   = true;
			_message = null;
		}

		#endregion

		#region Public properties

		private bool _valid;
		public  bool  Valid
		{
			get { return _valid;  }
			set { _valid = value; }
		}

		private readonly bool _thisPageOnly;
		public  bool           ThisPageOnly
		{
			get { return _thisPageOnly;  }
		}

		private string _message;
		public  string  Message
		{
			get { return _message;  }
			set { _message = value; }
		}

		private Control _control;
		public  Control  Control
		{
			get { return _control;  }
			set { _control = value; }
		}

		#endregion

		#region Public methods

		public void SetInvalid(string message)
		{
			Valid = false;
			Message = message;
		}

		public void SetInvalid(string message, Control c)
		{
			Valid = false;
			Message = message;
			Control = c;
		}

		#endregion
	}
}