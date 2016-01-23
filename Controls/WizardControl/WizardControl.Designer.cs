namespace ITTrust.UI.Common
{
	partial class WizardControl
	{
		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.Label separatorLabel;
            System.Windows.Forms.ColumnHeader pageName;
            this.bottomPanel = new System.Windows.Forms.Panel();
            this._apply = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._finish = new System.Windows.Forms.Button();
            this._next = new System.Windows.Forms.Button();
            this._back = new System.Windows.Forms.Button();
            this._pagesList = new System.Windows.Forms.ListView();
            this._captionLabel = new System.Windows.Forms.Label();
            this._pages = new ITTrust.UI.Common.WizardControl.PagesHolder();
            separatorLabel = new System.Windows.Forms.Label();
            pageName = new System.Windows.Forms.ColumnHeader();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // separatorLabel
            // 
            separatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            separatorLabel.Location = new System.Drawing.Point(0, 2);
            separatorLabel.Name = "separatorLabel";
            separatorLabel.Size = new System.Drawing.Size(374, 2);
            separatorLabel.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this._apply);
            this.bottomPanel.Controls.Add(this._cancel);
            this.bottomPanel.Controls.Add(this._finish);
            this.bottomPanel.Controls.Add(this._next);
            this.bottomPanel.Controls.Add(this._back);
            this.bottomPanel.Controls.Add(separatorLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 232);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(374, 50);
            this.bottomPanel.TabIndex = 1;
            // 
            // _apply
            // 
            this._apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._apply.Location = new System.Drawing.Point(288, 14);
            this._apply.Name = "_apply";
            this._apply.Size = new System.Drawing.Size(74, 23);
            this._apply.TabIndex = 5;
            this._apply.Text = "При&менить";
            this._apply.UseVisualStyleBackColor = true;
            this._apply.Visible = false;
            this._apply.Click += new System.EventHandler(this.HandleApplyClick);
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel.Location = new System.Drawing.Point(288, 14);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(74, 23);
            this._cancel.TabIndex = 4;
            this._cancel.Text = "Отмена";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this.HandleCancelClick);
            // 
            // _finish
            // 
            this._finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._finish.Location = new System.Drawing.Point(208, 14);
            this._finish.Name = "_finish";
            this._finish.Size = new System.Drawing.Size(74, 23);
            this._finish.TabIndex = 3;
            this._finish.UseVisualStyleBackColor = true;
            this._finish.Click += new System.EventHandler(this.HandleFinishClick);
            // 
            // _next
            // 
            this._next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._next.Enabled = false;
            this._next.Location = new System.Drawing.Point(114, 14);
            this._next.Name = "_next";
            this._next.Size = new System.Drawing.Size(74, 23);
            this._next.TabIndex = 2;
            this._next.Text = "&Вперёд >";
            this._next.UseVisualStyleBackColor = true;
            this._next.Click += new System.EventHandler(this.HandleNextClick);
            // 
            // _back
            // 
            this._back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._back.Enabled = false;
            this._back.Location = new System.Drawing.Point(34, 14);
            this._back.Name = "_back";
            this._back.Size = new System.Drawing.Size(74, 23);
            this._back.TabIndex = 1;
            this._back.Text = "< &Назад";
            this._back.UseVisualStyleBackColor = true;
            this._back.Click += new System.EventHandler(this.HandleBackClick);
            // 
            // _pagesList
            // 
            this._pagesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            pageName});
            this._pagesList.Dock = System.Windows.Forms.DockStyle.Left;
            this._pagesList.FullRowSelect = true;
            this._pagesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._pagesList.HideSelection = false;
            this._pagesList.Location = new System.Drawing.Point(0, 0);
            this._pagesList.MultiSelect = false;
            this._pagesList.Name = "_pagesList";
            this._pagesList.Size = new System.Drawing.Size(156, 232);
            this._pagesList.TabIndex = 2;
            this._pagesList.UseCompatibleStateImageBehavior = false;
            this._pagesList.View = System.Windows.Forms.View.Details;
            this._pagesList.VirtualMode = true;
            this._pagesList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleMouseUp);
            this._pagesList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleMouseMove);
            this._pagesList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.HandleRetrieveVirtualItem);
            this._pagesList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.HandleItemSelectionChanged);
            // 
            // _captionLabel
            // 
            this._captionLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this._captionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._captionLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._captionLabel.Location = new System.Drawing.Point(156, 0);
            this._captionLabel.Name = "_captionLabel";
            this._captionLabel.Size = new System.Drawing.Size(218, 24);
            this._captionLabel.TabIndex = 3;
            this._captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _pages
            // 
            this._pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pages.Location = new System.Drawing.Point(156, 24);
            this._pages.Name = "_pages";
            this._pages.Size = new System.Drawing.Size(218, 208);
            this._pages.TabIndex = 0;
            this._pages.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.HandlePageControlRemoved);
            this._pages.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.HandlePageControlAdded);
            // 
            // WizardControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this._pages);
            this.Controls.Add(this._captionLabel);
            this.Controls.Add(this._pagesList);
            this.Controls.Add(this.bottomPanel);
            this.Name = "WizardControl";
            this.Size = new System.Drawing.Size(374, 282);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.ListView _pagesList;
		internal System.Windows.Forms.Button _back;
		internal System.Windows.Forms.Button _cancel;
		internal System.Windows.Forms.Button _finish;
		internal System.Windows.Forms.Button _next;
		internal System.Windows.Forms.Label _captionLabel;
		private PagesHolder _pages;
		internal System.Windows.Forms.Button _apply;
        internal System.Windows.Forms.Panel bottomPanel;
	}
}