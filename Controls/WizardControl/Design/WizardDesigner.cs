using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ITTrust.UI.Common.Design
{
	internal class WizardDesigner : ParentControlDesigner
	{
		private WizardControl WizardControl
		{
			get { return (WizardControl)Control; }
		}

		protected override void Dispose(bool disposing)
		{
			ISelectionService selectionSrv = (ISelectionService)GetService(typeof(ISelectionService));

			selectionSrv.SelectionChanged -= OnSelectionChanged;
			base.Dispose(disposing);
		}

		public override void Initialize(IComponent component)
		{
			base.Initialize(component);

			ISelectionService selectionSrv = (ISelectionService)GetService(typeof(ISelectionService));

			selectionSrv.SelectionChanged += OnSelectionChanged;
		}

		private void OnSelectionChanged(object sender, EventArgs e)
		{
			ISelectionService selection = (ISelectionService)sender;

			foreach (WizardPage page in WizardControl.Pages)
			{
				if (selection.GetComponentSelected(page))
				{
					WizardControl.SelectedPage = page;
					break;
				}
			}
		}

		/// <summary>
		/// Simple way to ensure <see cref="WizardPage"/>s only contained here
		/// </summary>
		/// <param name="control"></param>
		/// <returns></returns>
		public override bool CanParent(Control control)
		{
			return control is WizardPage;
		}

		public override bool CanParent(ControlDesigner controlDesigner)
		{
			return controlDesigner is WizardPageDesigner;
		}

		protected override bool GetHitTest(Point point)
		{
			WizardControl wiz = WizardControl;

			return HitTestControls(point, wiz._next, wiz._back, wiz._pagesList);
		}


		private static bool HitTestControls(Point pt, params Control[] ctls)
		{
			for (int i = 0; i < ctls.Length; i++)
			{
				Control ctl = ctls[i];

				if (ctl.Enabled && ctl.ClientRectangle.Contains(ctl.PointToClient(pt)))
				{
					return true;
				}
			}

			return false;
		}

		public override DesignerVerbCollection Verbs
		{
			get
			{
				DesignerVerbCollection verbs = base.Verbs;
				if (verbs.Count == 0)
				{
					verbs.Add(new DesignerVerb("Add New Page", OnAddPage));
					verbs.Add(new DesignerVerb("Adjust Form", OnAdjustForm));
				}
				return verbs;
			}
		}

		internal void OnAddPage(object sender, EventArgs e)
		{
			WizardControl wizardControl = WizardControl;

			IDesignerHost h  = (IDesignerHost) GetService(typeof(IDesignerHost));
			IComponentChangeService c = (IComponentChangeService) GetService(typeof (IComponentChangeService));

			using (DesignerTransaction dt = h.CreateTransaction("Add Page"))
			{
				WizardPage page = (WizardPage) h.CreateComponent(typeof(WizardPage));
				c.OnComponentChanging(wizardControl, null);

				//Add a new page to the collection
				wizardControl.Pages.Add(page);
				page.Text = page.Name;
				wizardControl.SelectedPage = page;

				c.OnComponentChanged(wizardControl, null, null, null);
				dt.Commit();
			}
		}


		internal void OnAdjustForm(object sender, EventArgs e)
		{
			IComponentChangeService changeSrv = (IComponentChangeService)GetService(typeof(IComponentChangeService));
			WizardControl wizardControl = WizardControl;
			Form parentForm = wizardControl.ParentForm;

			if (parentForm != null)
			{
				changeSrv.OnComponentChanging(parentForm, null);
				parentForm.Padding       = Padding.Empty;
				parentForm.MinimumSize   = Size.Empty;
				parentForm.ClientSize    = wizardControl.MinimumSize.IsEmpty? wizardControl.Size: wizardControl.MinimumSize;
				parentForm.MinimumSize   = parentForm.Size;
				parentForm.StartPosition = FormStartPosition.CenterParent;
				parentForm.ShowInTaskbar = false;
				parentForm.MinimizeBox   = false;
				parentForm.MaximizeBox   = false;
				parentForm.AutoSize      = true;
				parentForm.AutoSizeMode  = AutoSizeMode.GrowAndShrink;;
				changeSrv.OnComponentChanged(parentForm, null, null, null);
			}

			DockStyle        oldDockStyle;
			MemberDescriptor propertyDock = TypeDescriptor.GetProperties(wizardControl)["Dock"];

			changeSrv.OnComponentChanging(wizardControl, propertyDock);
			oldDockStyle = wizardControl.Dock;
			wizardControl.Dock = DockStyle.Fill;
			changeSrv.OnComponentChanged(wizardControl, propertyDock, oldDockStyle, wizardControl.Dock);
		}
	}
}