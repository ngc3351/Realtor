namespace Realtor.Controls
{
    partial class ObjectsBrowserEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectsBrowserEx));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.refreshObjectsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addObjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dropObjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editObjectTolStripButton = new System.Windows.Forms.ToolStripButton();
            this.filterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._columnsSelectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._showFlatsCmd = new System.Windows.Forms.ToolStripButton();
            this._showCottageCmd = new System.Windows.Forms.ToolStripButton();
            this._showLandCmd = new System.Windows.Forms.ToolStripButton();
            this._showNonresidentCmd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._showSaleCmd = new System.Windows.Forms.ToolStripButton();
            this._showLeaseCmd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._demandToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._supplyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._cityToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this._exportMenuStrip = new System.Windows.Forms.MenuStrip();
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cottegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noresidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridView1 = new Realtor.MyGrid();
            this._leftPanel = new System.Windows.Forms.Panel();
            this._rightPanel = new System.Windows.Forms.Panel();
            this.menuBuddyProvider1 = new ITTrust.UI.Common.MenuBuddyProvider(this.components);
            this._clientTolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this._exportMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshObjectsToolStripButton,
            this.addObjectToolStripButton,
            this.dropObjectToolStripButton,
            this.editObjectTolStripButton,
            this.filterToolStripButton,
            this._clientTolStripButton,
            this._columnsSelectToolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(639, 25);
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
            // filterToolStripButton
            // 
            this.filterToolStripButton.Image = global::Realtor.Properties.Resources.find;
            this.filterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterToolStripButton.Name = "filterToolStripButton";
            this.filterToolStripButton.Size = new System.Drawing.Size(65, 22);
            this.filterToolStripButton.Text = "Фильтр";
            this.filterToolStripButton.Click += new System.EventHandler(this.cmdShowFilter);
            // 
            // _columnsSelectToolStripButton
            // 
            this._columnsSelectToolStripButton.Image = global::Realtor.Properties.Resources.table_preferences;
            this._columnsSelectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._columnsSelectToolStripButton.Name = "_columnsSelectToolStripButton";
            this._columnsSelectToolStripButton.Size = new System.Drawing.Size(81, 22);
            this._columnsSelectToolStripButton.Text = "Настройка";
            this._columnsSelectToolStripButton.ToolTipText = "Настройка полей таблицы";
            this._columnsSelectToolStripButton.Click += new System.EventHandler(this.cmdShowColumnsSelector);
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
            this.toolStripSeparator2,
            this._demandToolStripButton,
            this._supplyToolStripButton,
            this.toolStripSeparator3,
            this._cityToolStripComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(639, 25);
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
            this._showLeaseCmd.Size = new System.Drawing.Size(49, 22);
            this._showLeaseCmd.Tag = "3";
            this._showLeaseCmd.Text = "Аренда";
            this._showLeaseCmd.Click += new System.EventHandler(this.cmdObjectsChangeAction);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _demandToolStripButton
            // 
            this._demandToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._demandToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_demandToolStripButton.Image")));
            this._demandToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._demandToolStripButton.Name = "_demandToolStripButton";
            this._demandToolStripButton.Size = new System.Drawing.Size(41, 22);
            this._demandToolStripButton.Text = "Спрос";
            this._demandToolStripButton.Click += new System.EventHandler(this.demandToolStripButton_Click);
            // 
            // _supplyToolStripButton
            // 
            this._supplyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._supplyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_supplyToolStripButton.Image")));
            this._supplyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._supplyToolStripButton.Name = "_supplyToolStripButton";
            this._supplyToolStripButton.Size = new System.Drawing.Size(81, 22);
            this._supplyToolStripButton.Text = "Предложение";
            this._supplyToolStripButton.Click += new System.EventHandler(this.supplyToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // _cityToolStripComboBox
            // 
            this._cityToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cityToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this._cityToolStripComboBox.Name = "_cityToolStripComboBox";
            this._cityToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this._cityToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.cityToolStripComboBox_SelectedIndexChanged);
            // 
            // _exportMenuStrip
            // 
            this._exportMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectsToolStripMenuItem});
            this._exportMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._exportMenuStrip.Name = "_exportMenuStrip";
            this._exportMenuStrip.Size = new System.Drawing.Size(639, 24);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._leftPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._rightPanel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 246);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // gridView1
            // 
            this.gridView1.AllowUserToAddRows = false;
            this.gridView1.AllowUserToDeleteRows = false;
            this.gridView1.AllowUserToResizeRows = false;
            this.gridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView1.GridColor = System.Drawing.Color.Silver;
            this.gridView1.Location = new System.Drawing.Point(203, 3);
            this.gridView1.MultiSelect = false;
            this.gridView1.Name = "gridView1";
            this.gridView1.ReadOnly = true;
            this.gridView1.RowHeadersVisible = false;
            this.gridView1.RowTemplate.Height = 17;
            this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView1.Size = new System.Drawing.Size(233, 240);
            this.gridView1.TabIndex = 11;
            // 
            // _leftPanel
            // 
            this._leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._leftPanel.Location = new System.Drawing.Point(0, 0);
            this._leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this._leftPanel.Name = "_leftPanel";
            this._leftPanel.Size = new System.Drawing.Size(200, 246);
            this._leftPanel.TabIndex = 12;
            this._leftPanel.Visible = false;
            // 
            // _rightPanel
            // 
            this._rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rightPanel.Location = new System.Drawing.Point(439, 0);
            this._rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this._rightPanel.Name = "_rightPanel";
            this._rightPanel.Size = new System.Drawing.Size(200, 246);
            this._rightPanel.TabIndex = 13;
            this._rightPanel.Visible = false;
            // 
            // _clientTolStripButton
            // 
            this._clientTolStripButton.Image = global::Realtor.Properties.Resources.id_card;
            this._clientTolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._clientTolStripButton.Name = "_clientTolStripButton";
            this._clientTolStripButton.Size = new System.Drawing.Size(64, 22);
            this._clientTolStripButton.Text = "Клиент";
            this._clientTolStripButton.Click += new System.EventHandler(this.cmdShowClient);
            // 
            // ObjectsBrowserEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this._exportMenuStrip);
            this.Name = "ObjectsBrowserEx";
            this.Size = new System.Drawing.Size(639, 320);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this._exportMenuStrip.ResumeLayout(false);
            this._exportMenuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton refreshObjectsToolStripButton;
        private System.Windows.Forms.ToolStripButton addObjectToolStripButton;
        private System.Windows.Forms.ToolStripButton dropObjectToolStripButton;
        private System.Windows.Forms.ToolStripButton editObjectTolStripButton;
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
        private Realtor.MyGrid gridView1;
        private System.Windows.Forms.ToolStripButton filterToolStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel _leftPanel;
        private System.Windows.Forms.ToolStripButton _demandToolStripButton;
        private System.Windows.Forms.ToolStripButton _supplyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox _cityToolStripComboBox;
        private System.Windows.Forms.Panel _rightPanel;
        private System.Windows.Forms.ToolStripButton _columnsSelectToolStripButton;
        private System.Windows.Forms.ToolStripButton _clientTolStripButton;
    }
}
