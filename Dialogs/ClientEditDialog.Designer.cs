namespace Realtor.Dialogs
{
    partial class ClientEditDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientEditDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._addButton = new System.Windows.Forms.Button();
            this._pagerTextBox = new System.Windows.Forms.TextBox();
            this._clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._statComboBox = new System.Windows.Forms.ComboBox();
            this._addressTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._typeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._phoneTextBox = new System.Windows.Forms.TextBox();
            this._emailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._namesComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._clientBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._addButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this._pagerTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this._statComboBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this._addressTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._typeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._phoneTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._emailTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this._namesComboBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 219);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(6, 191);
            this._addButton.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(100, 22);
            this._addButton.TabIndex = 14;
            this._addButton.Text = "Новый клиент";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.CmdAddClient);
            // 
            // _pagerTextBox
            // 
            this._pagerTextBox.AcceptsReturn = true;
            this._pagerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._clientBindingSource, "Pager", true));
            this._pagerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pagerTextBox.Location = new System.Drawing.Point(170, 135);
            this._pagerTextBox.Name = "_pagerTextBox";
            this._pagerTextBox.Size = new System.Drawing.Size(210, 20);
            this._pagerTextBox.TabIndex = 11;
            // 
            // _statComboBox
            // 
            this._statComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._clientBindingSource, "Stat", true));
            this._statComboBox.DisplayMember = "Value";
            this._statComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._statComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._statComboBox.FormattingEnabled = true;
            this._statComboBox.Location = new System.Drawing.Point(170, 161);
            this._statComboBox.Name = "_statComboBox";
            this._statComboBox.Size = new System.Drawing.Size(210, 21);
            this._statComboBox.TabIndex = 13;
            this._statComboBox.Tag = "";
            this._statComboBox.ValueMember = "Key";
            // 
            // _addressTextBox
            // 
            this._addressTextBox.AcceptsReturn = true;
            this._addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._clientBindingSource, "Address", true));
            this._addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addressTextBox.Location = new System.Drawing.Point(170, 57);
            this._addressTextBox.Name = "_addressTextBox";
            this._addressTextBox.Size = new System.Drawing.Size(210, 20);
            this._addressTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this._okButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._cancelButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(170, 188);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 28);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(3, 3);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(100, 22);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "Сохранить";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(109, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(100, 22);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Отмена";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Ф.И.О. или наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Юридический статус:";
            // 
            // _typeComboBox
            // 
            this._typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._clientBindingSource, "Types", true));
            this._typeComboBox.DisplayMember = "Value";
            this._typeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._typeComboBox.FormattingEnabled = true;
            this._typeComboBox.Location = new System.Drawing.Point(170, 30);
            this._typeComboBox.Name = "_typeComboBox";
            this._typeComboBox.Size = new System.Drawing.Size(210, 21);
            this._typeComboBox.TabIndex = 3;
            this._typeComboBox.Tag = "";
            this._typeComboBox.ValueMember = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Контактные телефоны:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Адрес(улица, дом, квартира):";
            // 
            // _phoneTextBox
            // 
            this._phoneTextBox.AcceptsReturn = true;
            this._phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._clientBindingSource, "Phone", true));
            this._phoneTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._phoneTextBox.Location = new System.Drawing.Point(170, 83);
            this._phoneTextBox.Name = "_phoneTextBox";
            this._phoneTextBox.Size = new System.Drawing.Size(210, 20);
            this._phoneTextBox.TabIndex = 7;
            // 
            // _emailTextBox
            // 
            this._emailTextBox.AcceptsReturn = true;
            this._emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._clientBindingSource, "Mail", true));
            this._emailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._emailTextBox.Location = new System.Drawing.Point(170, 109);
            this._emailTextBox.Name = "_emailTextBox";
            this._emailTextBox.Size = new System.Drawing.Size(210, 20);
            this._emailTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "&Электронная почта:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "&Пейджер:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "&Текущее состояние:";
            // 
            // _namesComboBox
            // 
            this._namesComboBox.DisplayMember = "Names";
            this._namesComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._namesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._namesComboBox.FormattingEnabled = true;
            this._namesComboBox.Location = new System.Drawing.Point(170, 3);
            this._namesComboBox.Name = "_namesComboBox";
            this._namesComboBox.Size = new System.Drawing.Size(210, 21);
            this._namesComboBox.TabIndex = 1;
            this._namesComboBox.ValueMember = "IDclient";
            this._namesComboBox.SelectedIndexChanged += new System.EventHandler(this.namesComboBox_SelectedIndexChanged);
            // 
            // ClientEditDialog
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(383, 219);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientEditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Карточка клиента";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._clientBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox _addressTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _typeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _phoneTextBox;
        private System.Windows.Forms.TextBox _emailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _statComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _pagerTextBox;
        private System.Windows.Forms.BindingSource _clientBindingSource;
        private System.Windows.Forms.ComboBox _namesComboBox;
        private System.Windows.Forms.Button _addButton;
    }
}