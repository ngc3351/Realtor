namespace Realtor.Dialogs
{
    partial class CompanyEditDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyEditDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._addressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._messageLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cityComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._phoneTextBox = new System.Windows.Forms.TextBox();
            this._emailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._addressTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._messageLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._nameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._cityComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._phoneTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this._emailTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 210);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _addressTextBox
            // 
            this._addressTextBox.AcceptsReturn = true;
            this._addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addressTextBox.Location = new System.Drawing.Point(113, 81);
            this._addressTextBox.MaxLength = 16;
            this._addressTextBox.Name = "_addressTextBox";
            this._addressTextBox.Size = new System.Drawing.Size(212, 20);
            this._addressTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите информацию о компании";
            // 
            // _messageLabel
            // 
            this._messageLabel.AutoSize = true;
            this._messageLabel.Location = new System.Drawing.Point(113, 159);
            this._messageLabel.Margin = new System.Windows.Forms.Padding(3);
            this._messageLabel.Name = "_messageLabel";
            this._messageLabel.Size = new System.Drawing.Size(193, 13);
            this._messageLabel.TabIndex = 7;
            this._messageLabel.Text = "* требуется подключение к интернет";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this._okButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._cancelButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(113, 178);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 29);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(3, 3);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(100, 23);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "Продолжить";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(109, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(100, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Закрыть";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя компании:";
            // 
            // _nameTextBox
            // 
            this._nameTextBox.AcceptsReturn = true;
            this._nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameTextBox.Location = new System.Drawing.Point(113, 28);
            this._nameTextBox.MaxLength = 16;
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(212, 20);
            this._nameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Город:";
            // 
            // _cityComboBox
            // 
            this._cityComboBox.DisplayMember = "City";
            this._cityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cityComboBox.FormattingEnabled = true;
            this._cityComboBox.Location = new System.Drawing.Point(113, 54);
            this._cityComboBox.Name = "_cityComboBox";
            this._cityComboBox.Size = new System.Drawing.Size(212, 21);
            this._cityComboBox.TabIndex = 9;
            this._cityComboBox.Tag = "";
            this._cityComboBox.ValueMember = "IdCity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Телефон:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Адрес:";
            // 
            // _phoneTextBox
            // 
            this._phoneTextBox.AcceptsReturn = true;
            this._phoneTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._phoneTextBox.Location = new System.Drawing.Point(113, 107);
            this._phoneTextBox.MaxLength = 16;
            this._phoneTextBox.Name = "_phoneTextBox";
            this._phoneTextBox.Size = new System.Drawing.Size(212, 20);
            this._phoneTextBox.TabIndex = 6;
            // 
            // _emailTextBox
            // 
            this._emailTextBox.AcceptsReturn = true;
            this._emailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._emailTextBox.Location = new System.Drawing.Point(113, 133);
            this._emailTextBox.MaxLength = 16;
            this._emailTextBox.Name = "_emailTextBox";
            this._emailTextBox.Size = new System.Drawing.Size(212, 20);
            this._emailTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail:";
            // 
            // CompanyEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 210);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompanyEditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание компании";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox _addressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _messageLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _cityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _phoneTextBox;
        private System.Windows.Forms.TextBox _emailTextBox;
        private System.Windows.Forms.Label label6;
    }
}