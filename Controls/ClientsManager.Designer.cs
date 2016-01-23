namespace Realtor.Controls
{
    partial class ClientsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._filterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._objectsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._contactsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addToolStripButton,
            this._deleteToolStripButton,
            this._editToolStripButton,
            this._filterToolStripButton,
            this._objectsToolStripButton,
            this._contactsToolStripButton,
            this._printToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(620, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _addToolStripButton
            // 
            this._addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_addToolStripButton.Image")));
            this._addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addToolStripButton.Name = "_addToolStripButton";
            this._addToolStripButton.Size = new System.Drawing.Size(77, 22);
            this._addToolStripButton.Text = "Добавить";
            this._addToolStripButton.Click += new System.EventHandler(this.CmdClientAdd);
            // 
            // _deleteToolStripButton
            // 
            this._deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_deleteToolStripButton.Image")));
            this._deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._deleteToolStripButton.Name = "_deleteToolStripButton";
            this._deleteToolStripButton.Size = new System.Drawing.Size(71, 22);
            this._deleteToolStripButton.Text = "Удалить";
            this._deleteToolStripButton.Click += new System.EventHandler(this.CmdClientDelete);
            // 
            // _editToolStripButton
            // 
            this._editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_editToolStripButton.Image")));
            this._editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._editToolStripButton.Name = "_editToolStripButton";
            this._editToolStripButton.Size = new System.Drawing.Size(76, 22);
            this._editToolStripButton.Text = "Карточка";
            this._editToolStripButton.Click += new System.EventHandler(this.CmdClientEdit);
            // 
            // _filterToolStripButton
            // 
            this._filterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_filterToolStripButton.Image")));
            this._filterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._filterToolStripButton.Name = "_filterToolStripButton";
            this._filterToolStripButton.Size = new System.Drawing.Size(65, 22);
            this._filterToolStripButton.Text = "Фильтр";
            this._filterToolStripButton.Click += new System.EventHandler(this.CmdFilterShow);
            // 
            // _objectsToolStripButton
            // 
            this._objectsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_objectsToolStripButton.Image")));
            this._objectsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._objectsToolStripButton.Name = "_objectsToolStripButton";
            this._objectsToolStripButton.Size = new System.Drawing.Size(74, 22);
            this._objectsToolStripButton.Text = "Объекты";
            this._objectsToolStripButton.Click += new System.EventHandler(this.CmdObjectsShow);
            // 
            // _contactsToolStripButton
            // 
            this._contactsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_contactsToolStripButton.Image")));
            this._contactsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._contactsToolStripButton.Name = "_contactsToolStripButton";
            this._contactsToolStripButton.Size = new System.Drawing.Size(78, 22);
            this._contactsToolStripButton.Text = "Контакты";
            this._contactsToolStripButton.Click += new System.EventHandler(this.CmdContactsShow);
            // 
            // _printToolStripButton
            // 
            this._printToolStripButton.Image = global::Realtor.Properties.Resources.printer;
            this._printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._printToolStripButton.Name = "_printToolStripButton";
            this._printToolStripButton.Size = new System.Drawing.Size(64, 22);
            this._printToolStripButton.Text = "Печать";
            this._printToolStripButton.Click += new System.EventHandler(this.CmdPrint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(196, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 18;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(421, 275);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DateReg";
            this.Column1.HeaderText = "Дата";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Names";
            this.Column2.HeaderText = "Ф.И.О. или наименование";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Phone";
            this.Column3.HeaderText = "Телефон";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "City";
            this.Column4.HeaderText = "Город";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Address";
            this.Column5.HeaderText = "Адрес";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Mail";
            this.Column6.HeaderText = "Эл. почта";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Types";
            this.Column7.HeaderText = "Тип";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Stat";
            this.Column8.HeaderText = "Статус";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 417);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 130);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 275);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // ClientsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ClientsManager";
            this.Size = new System.Drawing.Size(620, 442);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _addToolStripButton;
        private System.Windows.Forms.ToolStripButton _deleteToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton _editToolStripButton;
        private System.Windows.Forms.ToolStripButton _filterToolStripButton;
        private System.Windows.Forms.ToolStripButton _objectsToolStripButton;
        private System.Windows.Forms.ToolStripButton _contactsToolStripButton;
        private System.Windows.Forms.ToolStripButton _printToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
