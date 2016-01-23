namespace Realtor.Dialogs
{
    partial class LogonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogonForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._loginComboBox = new System.Windows.Forms.ComboBox();
            this._passTextBox = new System.Windows.Forms.TextBox();
            this._errorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._loginComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._passTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._errorLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.versionLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 153);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 5, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 5, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // _loginComboBox
            // 
            this._loginComboBox.DisplayMember = "Family";
            this._loginComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._loginComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._loginComboBox.FormattingEnabled = true;
            this._loginComboBox.Location = new System.Drawing.Point(95, 50);
            this._loginComboBox.Name = "_loginComboBox";
            this._loginComboBox.Size = new System.Drawing.Size(211, 21);
            this._loginComboBox.TabIndex = 1;
            this._loginComboBox.ValueMember = "IDperson";
            // 
            // _passTextBox
            // 
            this._passTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passTextBox.Location = new System.Drawing.Point(95, 77);
            this._passTextBox.Name = "_passTextBox";
            this._passTextBox.PasswordChar = '*';
            this._passTextBox.Size = new System.Drawing.Size(211, 20);
            this._passTextBox.TabIndex = 3;
            // 
            // _errorLabel
            // 
            this._errorLabel.AutoSize = true;
            this._errorLabel.ForeColor = System.Drawing.Color.White;
            this._errorLabel.Location = new System.Drawing.Point(95, 103);
            this._errorLabel.Margin = new System.Windows.Forms.Padding(3);
            this._errorLabel.Name = "_errorLabel";
            this._errorLabel.Size = new System.Drawing.Size(184, 13);
            this._errorLabel.TabIndex = 4;
            this._errorLabel.Text = "Ошибка, неверное имя или пароль";
            this._errorLabel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this._okButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._cancelButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 122);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(303, 29);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // _okButton
            // 
            this._okButton.BackColor = System.Drawing.SystemColors.Control;
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._okButton.Location = new System.Drawing.Point(3, 3);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(145, 23);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "Войти";
            this._okButton.UseVisualStyleBackColor = false;
            // 
            // _cancelButton
            // 
            this._cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._cancelButton.Location = new System.Drawing.Point(154, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(146, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Закрыть";
            this._cancelButton.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titleLabel.Location = new System.Drawing.Point(13, 3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 24);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Realtor";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.versionLabel.Location = new System.Drawing.Point(7, 27);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(82, 13);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "v1.0.2009.1036";
            // 
            // LogonForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Realtor.Properties.Resources.wait_form_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(309, 153);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(311, 134);
            this.Name = "LogonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _loginComboBox;
        private System.Windows.Forms.TextBox _passTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _errorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}