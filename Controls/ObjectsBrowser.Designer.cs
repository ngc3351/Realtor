namespace Realtor.Controls
{
    partial class ObjectsBrowser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectsBrowser));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.refreshObjectsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addObjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dropObjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editObjectTolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._showFlatsCmd = new System.Windows.Forms.ToolStripButton();
            this._showCottageCmd = new System.Windows.Forms.ToolStripButton();
            this._showLandCmd = new System.Windows.Forms.ToolStripButton();
            this._showNonresidentCmd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._showSaleCmd = new System.Windows.Forms.ToolStripButton();
            this._showLeaseCmd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._exportMenuStrip = new System.Windows.Forms.MenuStrip();
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cottegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noresidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuddyProvider1 = new ITTrust.UI.Common.MenuBuddyProvider(this.components);
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this._exportMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshObjectsToolStripButton,
            this.addObjectToolStripButton,
            this.dropObjectToolStripButton,
            this.editObjectTolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(345, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // refreshObjectsToolStripButton
            // 
            this.refreshObjectsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshObjectsToolStripButton.Image")));
            this.refreshObjectsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshObjectsToolStripButton.Name = "refreshObjectsToolStripButton";
            this.refreshObjectsToolStripButton.Size = new System.Drawing.Size(77, 22);
            this.refreshObjectsToolStripButton.Text = "Обновить";
            this.refreshObjectsToolStripButton.Click += new System.EventHandler(this.cmdRefreshObjects);
            // 
            // addObjectToolStripButton
            // 
            this.addObjectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addObjectToolStripButton.Image")));
            this.addObjectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addObjectToolStripButton.Name = "addObjectToolStripButton";
            this.addObjectToolStripButton.Size = new System.Drawing.Size(77, 22);
            this.addObjectToolStripButton.Text = "Добавить";
            this.addObjectToolStripButton.Click += new System.EventHandler(this.cmdAddObject);
            // 
            // dropObjectToolStripButton
            // 
            this.dropObjectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("dropObjectToolStripButton.Image")));
            this.dropObjectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropObjectToolStripButton.Name = "dropObjectToolStripButton";
            this.dropObjectToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.dropObjectToolStripButton.Text = "Удалить";
            this.dropObjectToolStripButton.Click += new System.EventHandler(this.cmdDropObject);
            // 
            // editObjectTolStripButton
            // 
            this.editObjectTolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editObjectTolStripButton.Image")));
            this.editObjectTolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editObjectTolStripButton.Name = "editObjectTolStripButton";
            this.editObjectTolStripButton.Size = new System.Drawing.Size(76, 22);
            this.editObjectTolStripButton.Text = "Карточка";
            this.editObjectTolStripButton.Click += new System.EventHandler(this.cmdViewObject);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 74);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4});
            this.gridControl1.Size = new System.Drawing.Size(345, 246);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumn1.FieldName = "Prava";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Value";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Key";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DisplayMember = "Value";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "Key";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._showFlatsCmd,
            this._showCottageCmd,
            this._showLandCmd,
            this._showNonresidentCmd,
            this.toolStripSeparator1,
            this._showSaleCmd,
            this._showLeaseCmd,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(345, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _showFlatsCmd
            // 
            this.menuBuddyProvider1.SetButtonBuddy(this._showFlatsCmd, this.flatToolStripMenuItem);
            this._showFlatsCmd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._showFlatsCmd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showFlatsCmd.Name = "_showFlatsCmd";
            this._showFlatsCmd.Size = new System.Drawing.Size(62, 22);
            this._showFlatsCmd.Tag = "";
            this._showFlatsCmd.Text = "Квартиры";
            // 
            // _showCottageCmd
            // 
            this.menuBuddyProvider1.SetButtonBuddy(this._showCottageCmd, this.cottegeToolStripMenuItem);
            this._showCottageCmd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._showCottageCmd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showCottageCmd.Name = "_showCottageCmd";
            this._showCottageCmd.Size = new System.Drawing.Size(63, 22);
            this._showCottageCmd.Tag = "";
            this._showCottageCmd.Text = "Коттеджи";
            // 
            // _showLandCmd
            // 
            this.menuBuddyProvider1.SetButtonBuddy(this._showLandCmd, this.landToolStripMenuItem);
            this._showLandCmd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._showLandCmd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showLandCmd.Name = "_showLandCmd";
            this._showLandCmd.Size = new System.Drawing.Size(41, 22);
            this._showLandCmd.Tag = "";
            this._showLandCmd.Text = "Земля";
            // 
            // _showNonresidentCmd
            // 
            this.menuBuddyProvider1.SetButtonBuddy(this._showNonresidentCmd, this.noresidentToolStripMenuItem);
            this._showNonresidentCmd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._showNonresidentCmd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showNonresidentCmd.Name = "_showNonresidentCmd";
            this._showNonresidentCmd.Size = new System.Drawing.Size(56, 22);
            this._showNonresidentCmd.Tag = "";
            this._showNonresidentCmd.Text = "Нежилье";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _showSaleCmd
            // 
            this._showSaleCmd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._showSaleCmd.Image = ((System.Drawing.Image)(resources.GetObject("_showSaleCmd.Image")));
            this._showSaleCmd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showSaleCmd.Name = "_showSaleCmd";
            this._showSaleCmd.Size = new System.Drawing.Size(57, 22);
            this._showSaleCmd.Tag = "1";
            this._showSaleCmd.Text = "Продажа";
            this._showSaleCmd.Click += new System.EventHandler(this.cmdObjectsChangeAction);
            // 
            // _showLeaseCmd
            // 
            this._showLeaseCmd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._showLeaseCmd.Image = ((System.Drawing.Image)(resources.GetObject("_showLeaseCmd.Image")));
            this._showLeaseCmd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._showLeaseCmd.Name = "_showLeaseCmd";
            this._showLeaseCmd.Size = new System.Drawing.Size(49, 17);
            this._showLeaseCmd.Tag = "3";
            this._showLeaseCmd.Text = "Аренда";
            this._showLeaseCmd.Click += new System.EventHandler(this.cmdObjectsChangeAction);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _exportMenuStrip
            // 
            this._exportMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectsToolStripMenuItem});
            this._exportMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._exportMenuStrip.Name = "_exportMenuStrip";
            this._exportMenuStrip.Size = new System.Drawing.Size(345, 24);
            this._exportMenuStrip.TabIndex = 10;
            this._exportMenuStrip.Text = "menuStrip1";
            // 
            // objectsToolStripMenuItem
            // 
            this.objectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flatToolStripMenuItem,
            this.cottegeToolStripMenuItem,
            this.landToolStripMenuItem,
            this.noresidentToolStripMenuItem});
            this.objectsToolStripMenuItem.Name = "objectsToolStripMenuItem";
            this.objectsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.objectsToolStripMenuItem.Text = "Объекты";
            // 
            // flatToolStripMenuItem
            // 
            this.flatToolStripMenuItem.Name = "flatToolStripMenuItem";
            this.flatToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.flatToolStripMenuItem.Tag = "1";
            this.flatToolStripMenuItem.Text = "Квартиры";
            this.flatToolStripMenuItem.Click += new System.EventHandler(this.cmdObjectsChangeType);
            // 
            // cottegeToolStripMenuItem
            // 
            this.cottegeToolStripMenuItem.Name = "cottegeToolStripMenuItem";
            this.cottegeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cottegeToolStripMenuItem.Tag = "2";
            this.cottegeToolStripMenuItem.Text = "Коттеджи";
            this.cottegeToolStripMenuItem.Click += new System.EventHandler(this.cmdObjectsChangeType);
            // 
            // landToolStripMenuItem
            // 
            this.landToolStripMenuItem.Name = "landToolStripMenuItem";
            this.landToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.landToolStripMenuItem.Tag = "3";
            this.landToolStripMenuItem.Text = "Земля";
            this.landToolStripMenuItem.Click += new System.EventHandler(this.cmdObjectsChangeType);
            // 
            // noresidentToolStripMenuItem
            // 
            this.noresidentToolStripMenuItem.Name = "noresidentToolStripMenuItem";
            this.noresidentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.noresidentToolStripMenuItem.Tag = "4";
            this.noresidentToolStripMenuItem.Text = "Нежилье";
            this.noresidentToolStripMenuItem.Click += new System.EventHandler(this.cmdObjectsChangeType);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.gridColumn2.FieldName = "Flour";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.gridColumn3.FieldName = "Flours";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DisplayMember = "Value";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "Key";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.gridColumn4.FieldName = "Flats";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.DisplayMember = "Value";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.ValueMember = "Key";
            // 
            // ObjectsBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this._exportMenuStrip);
            this.Name = "ObjectsBrowser";
            this.Size = new System.Drawing.Size(345, 320);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this._exportMenuStrip.ResumeLayout(false);
            this._exportMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton refreshObjectsToolStripButton;
        private System.Windows.Forms.ToolStripButton addObjectToolStripButton;
        private System.Windows.Forms.ToolStripButton dropObjectToolStripButton;
        private System.Windows.Forms.ToolStripButton editObjectTolStripButton;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _showFlatsCmd;
        private System.Windows.Forms.ToolStripButton _showCottageCmd;
        private System.Windows.Forms.ToolStripButton _showLandCmd;
        private System.Windows.Forms.ToolStripButton _showNonresidentCmd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _showSaleCmd;
        private System.Windows.Forms.ToolStripButton _showLeaseCmd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.MenuStrip _exportMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem objectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cottegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noresidentToolStripMenuItem;
        private ITTrust.UI.Common.MenuBuddyProvider menuBuddyProvider1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
    }
}
