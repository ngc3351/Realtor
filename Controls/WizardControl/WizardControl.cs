using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ITTrust.UI.Common.Design;

namespace ITTrust.UI.Common
{
	/// <summary>
	/// A wizard is the control added to a form to provide a step by step functionality.
	/// It contains <see cref="WizardPage"/>s in the <see cref="Pages"/> collection, which
	/// are containers for other controls. Only one wizard page is shown at a time in the client
	/// are of the wizard.
	/// </summary>
	[Designer(typeof(WizardDesigner))]
	[ToolboxItem(true), ToolboxBitmap(typeof(WizardControl))]
	public partial class WizardControl : UserControl
	{
		///<summary>
		/// Initializes a new instance of the WizardControl class.
		///</summary>
		public WizardControl()
		{
			InitializeComponent();
            _finish.Text = "&Готово";
			_captionLabel.Font = new Font(_captionLabel.Font, FontStyle.Bold);
			_pagesList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		[DefaultValue(typeof(Size), "500, 360")]
		public override Size MinimumSize
		{
			get { return base.MinimumSize; }
			set { base.MinimumSize = value; }
		}

		private WizardPage _selectedPage;
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public  WizardPage  SelectedPage
		{
			get { return _selectedPage; }
			set
			{
				if (_selectedPage == value)
					return;

				ClearInvalidPageStatus();

				if (value != null && value.Enabled && DoValidatePage(_selectedPage, true))
				{
					if (!Pages.Contains(value))
						throw new ArgumentException("value");

					WizardPageEventArgs args = new WizardPageEventArgs(value);

					// At this point Wizard.SelectedPage != args.Page
					//
					OnPageActivate(args);

					_selectedPage = value;

					UpdateCaptionText(value);

					ISelectionService selectionSrv = (ISelectionService)GetService(typeof(ISelectionService));
					if (selectionSrv != null)
						selectionSrv.SetSelectedComponents(new WizardPage[] {value});

					int index = SelectedPageIndex;

					_back.Enabled = FindPrevEnabledPage(index - 1) >= 0;
					_next.Enabled = FindNextEnabledPage(index + 1) >= 0;

					foreach (WizardPage page in Pages)
						page.Visible = page == value;

					OnPageActivated(args);
				}
				else if (_selectedPage == null)
				{
					_captionLabel.Text = null;
					_back.Enabled = _next.Enabled = false;
				}

				UpdateList();
			}
		}

		private bool DoValidatePage(WizardPage page, bool thisPageOnly)
		{
			if (page == null)
				return true;

			if (!page.Enabled)
				return false;

			WizardValidatePageEventArgs args = new WizardValidatePageEventArgs(page, thisPageOnly);

			OnPageValidate(args);

			if (!args.Valid)
			{
				// Force display this page

				SelectedPage = page;
				ReportInvalidPage(args.Message, args.Control);
			}

			return args.Valid;
		}

		internal void UpdateCaptionText(WizardPage value)
		{
			_captionLabel.Text = value.CaptionText ?? value.Text;
		}

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int SelectedPageIndex
		{
			get { return Pages.IndexOf(SelectedPage); }
			set
			{
				if (value < 0)
					SelectedPage = null;
				else
					SelectedPage = Pages[value];
			}
		}

		private bool _closeForm = true;
		[Category.Wizard]
		[Description("If True, the wizard applies either a DialogResult.OK or DialogResult.Cancel to the form automatically.")]
		[DefaultValue(true)]
		public  bool  CloseForm
		{
			get { return _closeForm; }
			set { _closeForm = value; }
		}

		private bool _prefixWithPageIndex = true;
		[Category.Wizard]
		[Description("If True, the wizard adds page index to page name in the list.")]
		[DefaultValue(true)]
		public  bool  PrefixWithPageIndex
		{
			get { return _prefixWithPageIndex; }
			set
			{
				_prefixWithPageIndex = value;
				if (Pages.Count > 0)
					_pagesList.RedrawItems(0, Pages.Count - 1, false);
			}
		}

		[Category.Wizard]
		[Description("If True, the wizard shows 'back' and 'next' buttons.")]
		[DefaultValue(true)]
		public  bool  ShowVizardButtons
		{
			get { return _back.Visible || _next.Visible; }
			set
			{
				_back.Visible = _next.Visible = value;
                _finish.Text = value ? "&Готово" : "ОК";
			}
		}

        [Category.Wizard]
        [Description("If True, the wizard shows 'back' and 'next' buttons.")]
        [DefaultValue(true)]
        public bool ShowButtonsPanel
        {
            get { return bottomPanel.Visible; }
            set
            {
                bottomPanel.Visible = value;

                if(!DesignMode)
                    _pagesList.Visible = value;
            }
        }

        private bool _pagesListVisibility = true;

        [Category.Wizard]
        [Description("If True, the wizard shows 'back' and 'next' buttons.")]
        [DefaultValue(true)]
        public bool ShowPagesList
        {
            get { return _pagesListVisibility; }
            set { _pagesListVisibility = value; }
        }

        private bool _pagesListVisibeDisigne = true;

        [Category.Wizard]
        [Description("If True, the wizard shows 'back' and 'next' buttons.")]
        [DefaultValue(true)]
        public bool ShowPagesListDesign
        {
            get { return _pagesListVisibeDisigne; }
            set 
            {
                _pagesListVisibeDisigne = value;

                if (DesignMode)
                    _pagesList.Visible = value;
            }
        }
		
        [Category.Wizard]
		[Description("If True, the wizard shows 'apply' button.")]
		[DefaultValue(false)]
		public  bool  ShowApplyButton
		{
			get { return _apply.Visible; }
			set
			{
				SuspendLayout();

				if (value && _apply.Left == _cancel.Left)
					MoveButtons(_finish.Left - _cancel.Left);
				else if (!value && _apply.Left != _cancel.Left)
					MoveButtons(_apply.Left - _cancel.Left);

				_apply.Visible = value;

				ResumeLayout();
			}
		}

		private void MoveButtons(int deltaX)
		{
			foreach (Control btn in _apply.Parent.Controls)
			{
				if (btn is Button && btn != _apply)
					btn.Left += deltaX;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public WizardPageCollection Pages
		{
			get { return (WizardPageCollection)_pages.Controls; }
		}

		#region Events

		private static readonly object eventPageActivate  = new object();
		private static readonly object eventPageActivated = new object();
		private static readonly object eventPageValidate  = new object();
		private static readonly object eventCancelled     = new object();
		private static readonly object eventFinished      = new object();
		private static readonly object eventApply         = new object();

		[Category.Behavior]
		public event EventHandler<WizardPageEventArgs> PageActivate
		{
			add    { Events.AddHandler   (eventPageActivate, value); }
			remove { Events.RemoveHandler(eventPageActivate, value); }
		}

		[Category.Behavior]
		public event EventHandler<WizardPageEventArgs> PageActivated
		{
			add    { Events.AddHandler   (eventPageActivated, value); }
			remove { Events.RemoveHandler(eventPageActivated, value); }
		}

		[Category.Behavior]
		public event EventHandler<EventArgs> Cancelled
		{
			add    { Events.AddHandler   (eventCancelled, value); }
			remove { Events.RemoveHandler(eventCancelled, value); }
		}

		[Category.Behavior]
		public event EventHandler<EventArgs> Apply
		{
			add    { Events.AddHandler   (eventApply, value); }
			remove { Events.RemoveHandler(eventApply, value); }
		}

		[Category.Behavior]
		public event EventHandler<EventArgs> Finished
		{
			add    { Events.AddHandler   (eventFinished, value); }
			remove { Events.RemoveHandler(eventFinished, value); }
		}

		[Category.Behavior]
		public event EventHandler<WizardValidatePageEventArgs> PageValidate
		{
			add    { Events.AddHandler   (eventPageValidate, value); }
			remove { Events.RemoveHandler(eventPageValidate, value); }
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
		protected virtual void OnPageActivate(WizardPageEventArgs e)
		{
			e.Page.OnActivate(e);
			FireEvent(eventPageActivate, e);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnPageActivated(WizardPageEventArgs e)
		{
			e.Page.OnActivated(e);
			FireEvent(eventPageActivated, e);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual bool OnPageValidate(WizardValidatePageEventArgs e)
		{
			e.Page.OnValidate(e);

			if (e.Valid)
				FireEvent(eventPageValidate, e);

			return e.Valid;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnCanceled(EventArgs e)
		{
			FireEvent(eventCancelled, e);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnFinished(EventArgs e)
		{
			FireEvent(eventFinished, e);
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		protected virtual void OnApply(EventArgs e)
		{
			FireEvent(eventApply, e);
		}

		#endregion

		public void GoBack()
		{
			SelectedPageIndex = FindPrevEnabledPage(SelectedPageIndex - 1);
			UpdateFormButtons();
		}

		public void GoNext()
		{
			SelectedPageIndex = FindNextEnabledPage(SelectedPageIndex + 1);
			UpdateFormButtons();
		}

        public void GoTo(WizardPage page)
        {
            SelectedPage = page;
            UpdateFormButtons();
        }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			SelectedPageIndex = FindNextEnabledPage(0);

			UpdateFormButtons();
		}

		private void UpdateFormButtons()
		{
			Form parentForm = ParentForm;
			if (parentForm == null)
				return;

			parentForm.AcceptButton = _next.Enabled && _next.Visible? _next: _finish.Enabled? _finish: null;
			parentForm.CancelButton = _cancel.Enabled? _cancel: null;
		}

		private int FindPrevEnabledPage(int from)
		{
			for (int i = from; i >= 0; --i)
			{
				if (Pages[i].Enabled)
					return i;
			}

			return -1;
		}

		private int FindNextEnabledPage(int from)
		{
			for (int i = from; i < Pages.Count; ++i)
			{
				if (Pages[i].Enabled)
					return i;
			}

			return -1;
		}

		private void HandleItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected)
				SelectedPage = (WizardPage)e.Item.Tag;
		}

		private void HandleRetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			WizardPage   page = Pages[e.ItemIndex];
			string       text = page.Text;
			if (_prefixWithPageIndex)
				text = (e.ItemIndex + 1) + " " + text;
			ListViewItem item = new ListViewItem(text);

			item.Tag = page;
			if (!page.Enabled)
			{
				item.BackColor = SystemColors.InactiveCaption;
				item.ForeColor = SystemColors.InactiveCaptionText;
			}

			e.Item = item;
		}

		private void HandleMouseMove(object sender, MouseEventArgs e)
		{
			ListView   list = (ListView) sender;
			ListViewHitTestInfo hit = list.HitTest(e.Location);
			list.Cursor = hit.Item == null? Cursors.Default:
				((WizardPage)hit.Item.Tag).Enabled? Cursors.Hand: Cursors.No;
		}

		private void HandleMouseUp(object sender, MouseEventArgs e)
		{
			UpdateList();
		}

		private void UpdateList()
		{
			int index = SelectedPageIndex;

			if (_pagesList.SelectedIndices.Count != 1 || _pagesList.SelectedIndices[0] != index)
			{
				_pagesList.SelectedIndices.Clear();
				if (index >= 0)
					_pagesList.SelectedIndices.Add(index);

				if (_pagesList.FocusedItem != null)
					_pagesList.FocusedItem.Focused = false;
			}
		}

		private void HandlePageControlAdded(object sender, ControlEventArgs e)
		{
			e.Control.Dock = DockStyle.Fill;
			Control pagesHolder = (Control)sender;
			_pagesList.VirtualListSize = pagesHolder.Controls.Count;
		}

		private void HandlePageControlRemoved(object sender, ControlEventArgs e)
		{
			Control pagesHolder = (Control)sender;
			_pagesList.VirtualListSize = pagesHolder.Controls.Count;
		}

		private void HandleBackClick(object sender, EventArgs e)
		{
			GoBack();
		}

		private void HandleNextClick(object sender, EventArgs e)
		{
			GoNext();
		}

		private void HandleFinishClick(object sender, EventArgs e)
		{
			if (ValidateAllPages())
			{
				if (_closeForm)
				{
					if (ParentForm != null)
						ParentForm.DialogResult = DialogResult.OK;
				}
				else
					OnFinished(EventArgs.Empty);
			}
		}

		private void HandleCancelClick(object sender, EventArgs e)
		{
			if (_closeForm)
			{
				if (ParentForm != null)
					ParentForm.DialogResult = DialogResult.Cancel;
			}
			else
				OnCanceled(EventArgs.Empty);
		}

		private void HandleApplyClick(object sender, EventArgs e)
		{
			if (ValidateAllPages())
			{
                _cancel.Text = "Закрыть";
				OnApply(EventArgs.Empty);
			}
		}

		private ErrorProvider _errorProvider;
		public ErrorProvider  ErrorProvider
		{
			get
			{
				if (null == _errorProvider)
				{
					_errorProvider = new ErrorProvider();
					_errorProvider.ContainerControl = this;
				}

				return _errorProvider;
			}
		}

		public void ReportInvalidPage(string message, Control control)
		{
			if (null != control)
			{
				control.Select();
				if (null != message)
				{
					ErrorProvider.Tag = control;
					ErrorProvider.SetError(control, message);
				}
			}
			else if (null != message)
			{
				Form owner = ParentForm;
				MessageBox.Show(owner, message, owner == null? Text: owner.Text,
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void ClearInvalidPageStatus()
		{
			if (null != _errorProvider)
			{
				_errorProvider.SetError((Control)_errorProvider.Tag, null);
			}
		}

		internal bool ValidateAllPages()
		{
			foreach (WizardPage page in Pages)
			{
				if (!page.Enabled)
					continue;

				if (!DoValidatePage(page, false))
					return false;
			}

			return true;
		}

		#region Nested Types

		///<summary>
		/// Represents a collection of WizardPages.
		///</summary>
		[ComVisible(false)]
		public class WizardPageCollection: ControlCollection
		{
			///<summary>
			/// Initializes a new instance of the WizardPageCollection class.
			///</summary>
			///<param name="owner">A WizardControl representing the control that owns the control collection.</param>
			public WizardPageCollection(Control owner): base(owner)
			{
			}

			///<summary>
			///Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"></see>.
			///</summary>
			///
			///<param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"></see>.</param>
			///<exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Generic.ICollection`1"></see> is read-only.</exception>
			public override void Add(Control item)
			{
				if (item is WizardPage)
					base.Add(item);
				else
					throw new ArgumentException(string.Format(
						"Cannot add '{0}' to WizardControl. Only WizardPages can be directly added to TabControls.", item.GetType().Name));
			}

			///<summary>
			///Indicates the <see cref="WizardPage"/> at the specified indexed location in the collection.
			///</summary>
			///
			///<returns>
			///The <see cref="WizardPage"/> located at the specified index location within the control collection.
			///</returns>
			///
			///<param name="index">The index of the control to retrieve from the control collection. </param>
			///<exception cref="T:System.ArgumentOutOfRangeException">The index value is less than zero or is greater than or equal to the number of controls in the collection. </exception>
			public new WizardPage this[int index]
			{
				get { return (WizardPage)base[index]; }
			}

			///<summary>
			///Indicates a <see cref="WizardPage"/> with the specified key in the collection.
			///</summary>
			///
			///<returns>
			///The <see cref="WizardPage"/> with the specified key within the <see cref="WizardPageCollection"/>.
			///</returns>
			///
			///<param name="key">The name of the control to retrieve from the control collection.</param>
			public new WizardPage this[string key]
			{
				get { return (WizardPage)base[key]; }
			}
		}

		private class PagesHolder : Panel
		{
			///<summary>
			///Creates a new instance of the control collection for the control.
			///</summary>
			///
			///<returns>
			///A new instance of <see cref="T:System.Windows.Forms.Control.ControlCollection"></see> assigned to the control.
			///</returns>
			///
			protected override ControlCollection CreateControlsInstance()
			{
				return new WizardPageCollection(this);
			}
		}

		#endregion
	}
}