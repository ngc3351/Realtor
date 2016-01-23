using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ITTrust.UI.Common
{
	[Designer(typeof(Design.WizardPageDesigner))]
	public class WizardPage : Panel
	{
		#region Suppressed properties

		[DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden), Browsable(false)]
		public override DockStyle Dock
		{
			get { return base.Dock;  }
			set { base.Dock = value; }
		}

		[DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden), Browsable(false)]
		public new Point Location
		{
			get { return base.Location;  }
			set { base.Location = value; }
		}

		[DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden), Browsable(false)]
		public new int TabIndex
		{
			get { return base.TabIndex;  }
			set { base.TabIndex = value; }
		}

		#endregion

		#region Events

		private static readonly object EventActivate  = new object();
		private static readonly object EventActivated = new object();
		private static readonly object EventValidate  = new object();

		[Category.Behavior]
		public event EventHandler<WizardPageEventArgs> Activate
		{
			add    { Events.AddHandler   (EventActivate, value); }
			remove { Events.RemoveHandler(EventActivate, value); }
		}

		[Category.Behavior]
		public event EventHandler<WizardPageEventArgs> Activated
		{
			add    { Events.AddHandler   (EventActivated, value); }
			remove { Events.RemoveHandler(EventActivated, value); }
		}

		[Category.Behavior]
		public event EventHandler<WizardValidatePageEventArgs> ValidatePage
		{
			add    { Events.AddHandler   (EventValidate, value); }
			remove { Events.RemoveHandler(EventValidate, value); }
		}

		private void FireEvent<T>(object o, T args) where T: EventArgs
		{
			using (new WaitCursor(this))
			{
				EventHandler<T> handler = (EventHandler<T>)Events[o];

				if (null != handler)
					handler(this, args);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal protected virtual void OnActivate(WizardPageEventArgs e)
		{
			FireEvent(EventActivate, e);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal protected virtual void OnActivated(WizardPageEventArgs e)
		{
			FireEvent(EventActivated, e);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal protected virtual bool OnValidate(WizardValidatePageEventArgs e)
		{
			FireEvent(EventValidate, e);

			return e.Valid;
		}

		#endregion

		[Bindable(true), Localizable(true), Browsable(true)]
		public override string Text
		{
			get { return base.Text;  }
			set
			{
				base.Text = value;
				if (Parent != null && Parent.Parent is WizardControl)
				{
					WizardControl wizardControl = (WizardControl)Parent.Parent;
					int idx = wizardControl.Pages.IndexOf(this);
					wizardControl._pagesList.RedrawItems(idx, idx, true);
					if (wizardControl.SelectedPage == this)
						wizardControl.UpdateCaptionText(this);
				}
			}
		}

		private string _captionText;
		[Bindable(true), Localizable(true), Browsable(true), DefaultValue(null)]
		[Category.Appearance]
		public  string  CaptionText
		{
			get { return _captionText;  }
			set
			{
				_captionText = value;
				if (Parent != null && Parent.Parent is WizardControl)
				{
					WizardControl wizardControl = (WizardControl)Parent.Parent;
					if (wizardControl.SelectedPage == this)
						wizardControl.UpdateCaptionText(this);
				}
			}
		}
	}
}