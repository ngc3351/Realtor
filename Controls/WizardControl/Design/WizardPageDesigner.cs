using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using ITTrust.UI.Common.Design;

namespace ITTrust.UI.Common.Design
{
	internal class WizardPageDesigner : ParentControlDesigner
	{
		///<summary>
		///Indicates if this designer's control can be parented by the control of the specified designer.
		///</summary>
		///
		///<returns>
		///true if the control managed by the specified designer can parent the control managed by this designer; otherwise, false.
		///</returns>
		///
		///<param name="parentDesigner">The <see cref="T:System.ComponentModel.Design.IDesigner"></see> that manages the control to check. </param>
		public override bool CanBeParentedTo(IDesigner parentDesigner)
		{
			return (parentDesigner is WizardDesigner);
		}

		///<summary>
		///Gets the selection rules that indicate the movement capabilities of a component.
		///</summary>
		///
		///<returns>
		///A bitwise combination of <see cref="T:System.Windows.Forms.Design.SelectionRules"></see> values.
		///</returns>
		///
		public override SelectionRules SelectionRules
		{
			get { return SelectionRules.Visible; }
		}

		private WizardControl ParentWizard
		{
			get { return (WizardControl)(Control == null? null: Control.Parent == null? null: Control.Parent.Parent);}
		}

		///<summary>
		///Gets the design-time verbs supported by the component that is associated with the designer.
		///</summary>
		///
		///<returns>
		///A <see cref="T:System.ComponentModel.Design.DesignerVerbCollection"></see> of <see cref="T:System.ComponentModel.Design.DesignerVerb"></see> objects, or null if no designer verbs are available. This default implementation always returns null.
		///</returns>
		///
		public override DesignerVerbCollection Verbs
		{
			get
			{
				Control parentWizard = ParentWizard;

				if (null != parentWizard)
				{
					IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
					WizardDesigner designer = (host.GetDesigner(parentWizard) as WizardDesigner);

					if (null != designer)
						return designer.Verbs;
				}

				return base.Verbs;
			}
		}
	}
}