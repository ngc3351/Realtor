namespace Realtor.Dialogs
{
    partial class ActivationWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivationWizard));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._forwardButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.wizardControl1 = new ITTrust.UI.Common.WizardControl();
            this.wizardPage1 = new ITTrust.UI.Common.WizardPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._regKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._messageLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wizardPage2 = new ITTrust.UI.Common.WizardPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this._addressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._cityComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._phoneTextBox = new System.Windows.Forms.TextBox();
            this._emailTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.wizardPage3 = new ITTrust.UI.Common.WizardPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this._pass2TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._loginTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this._passTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.wizardPage4 = new ITTrust.UI.Common.WizardPage();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.wizardPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.wizardPage3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.wizardPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.wizardControl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 242);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this._forwardButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._cancelButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(122, 210);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 29);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // _forwardButton
            // 
            this._forwardButton.Location = new System.Drawing.Point(3, 3);
            this._forwardButton.Name = "_forwardButton";
            this._forwardButton.Size = new System.Drawing.Size(100, 23);
            this._forwardButton.TabIndex = 2;
            this._forwardButton.Text = "Продолжить";
            this._forwardButton.UseVisualStyleBackColor = true;
            this._forwardButton.Click += new System.EventHandler(this._forwardButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(109, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(100, 23);
            this._cancelButton.TabIndex = 3;
            this._cancelButton.Text = "Закрыть";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // wizardControl1
            // 
            this.wizardControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(3, 3);
            this.wizardControl1.MinimumSize = new System.Drawing.Size(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.wizardPage1);
            this.wizardControl1.Pages.Add(this.wizardPage2);
            this.wizardControl1.Pages.Add(this.wizardPage3);
            this.wizardControl1.Pages.Add(this.wizardPage4);
            this.wizardControl1.ShowButtonsPanel = false;
            this.wizardControl1.ShowPagesList = false;
            this.wizardControl1.ShowPagesListDesign = false;
            this.wizardControl1.ShowVizardButtons = false;
            this.wizardControl1.Size = new System.Drawing.Size(331, 201);
            this.wizardControl1.TabIndex = 1;
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.tableLayoutPanel1);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(331, 177);
            this.wizardPage1.Text = "Ввод ключа";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._regKeyTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._messageLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _regKeyTextBox
            // 
            this._regKeyTextBox.AcceptsReturn = true;
            this._regKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._regKeyTextBox.Location = new System.Drawing.Point(122, 41);
            this._regKeyTextBox.MaxLength = 16;
            this._regKeyTextBox.Name = "_regKeyTextBox";
            this._regKeyTextBox.Size = new System.Drawing.Size(206, 20);
            this._regKeyTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ключ активации:";
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
            this.label2.Size = new System.Drawing.Size(319, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Для продолжения необходимо активировать вашу копию программы";
            // 
            // _messageLabel
            // 
            this._messageLabel.AutoSize = true;
            this._messageLabel.Location = new System.Drawing.Point(122, 67);
            this._messageLabel.Margin = new System.Windows.Forms.Padding(3);
            this._messageLabel.Name = "_messageLabel";
            this._messageLabel.Size = new System.Drawing.Size(193, 13);
            this._messageLabel.TabIndex = 4;
            this._messageLabel.Text = "* требуется подключение к интернет";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.tableLayoutPanel4);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(331, 177);
            this.wizardPage2.Text = "Информация о компании";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this._addressTextBox, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this._nameTextBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this._cityComboBox, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this._phoneTextBox, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this._emailTextBox, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(331, 177);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // _addressTextBox
            // 
            this._addressTextBox.AcceptsReturn = true;
            this._addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addressTextBox.Location = new System.Drawing.Point(113, 81);
            this._addressTextBox.MaxLength = 16;
            this._addressTextBox.Name = "_addressTextBox";
            this._addressTextBox.Size = new System.Drawing.Size(215, 20);
            this._addressTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите информацию о компании";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "* требуется подключение к интернет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Имя компании:";
            // 
            // _nameTextBox
            // 
            this._nameTextBox.AcceptsReturn = true;
            this._nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameTextBox.Location = new System.Drawing.Point(113, 28);
            this._nameTextBox.MaxLength = 16;
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(215, 20);
            this._nameTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Город:";
            // 
            // _cityComboBox
            // 
            this._cityComboBox.DisplayMember = "City";
            this._cityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cityComboBox.FormattingEnabled = true;
            this._cityComboBox.Location = new System.Drawing.Point(113, 54);
            this._cityComboBox.Name = "_cityComboBox";
            this._cityComboBox.Size = new System.Drawing.Size(215, 21);
            this._cityComboBox.TabIndex = 9;
            this._cityComboBox.Tag = "";
            this._cityComboBox.ValueMember = "IdCity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Телефон:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Адрес:";
            // 
            // _phoneTextBox
            // 
            this._phoneTextBox.AcceptsReturn = true;
            this._phoneTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._phoneTextBox.Location = new System.Drawing.Point(113, 107);
            this._phoneTextBox.MaxLength = 16;
            this._phoneTextBox.Name = "_phoneTextBox";
            this._phoneTextBox.Size = new System.Drawing.Size(215, 20);
            this._phoneTextBox.TabIndex = 6;
            // 
            // _emailTextBox
            // 
            this._emailTextBox.AcceptsReturn = true;
            this._emailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._emailTextBox.Location = new System.Drawing.Point(113, 133);
            this._emailTextBox.MaxLength = 16;
            this._emailTextBox.Name = "_emailTextBox";
            this._emailTextBox.Size = new System.Drawing.Size(215, 20);
            this._emailTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "E-mail:";
            // 
            // wizardPage3
            // 
            this.wizardPage3.Controls.Add(this.tableLayoutPanel5);
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(331, 177);
            this.wizardPage3.Text = "Создание администратора";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this._pass2TextBox, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this._loginTextBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this._passTextBox, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(331, 177);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // _pass2TextBox
            // 
            this._pass2TextBox.AcceptsReturn = true;
            this._pass2TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pass2TextBox.Location = new System.Drawing.Point(138, 93);
            this._pass2TextBox.MaxLength = 16;
            this._pass2TextBox.Name = "_pass2TextBox";
            this._pass2TextBox.PasswordChar = '*';
            this._pass2TextBox.Size = new System.Drawing.Size(190, 20);
            this._pass2TextBox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label10, 2);
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Необходимо создать пользователя с административными правами";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 26);
            this.label11.TabIndex = 7;
            this.label11.Text = "* требуется подключение к интернет";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 43);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Имя пользователя:";
            // 
            // _loginTextBox
            // 
            this._loginTextBox.AcceptsReturn = true;
            this._loginTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._loginTextBox.Location = new System.Drawing.Point(138, 41);
            this._loginTextBox.MaxLength = 16;
            this._loginTextBox.Name = "_loginTextBox";
            this._loginTextBox.Size = new System.Drawing.Size(190, 20);
            this._loginTextBox.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Пароль:";
            // 
            // _passTextBox
            // 
            this._passTextBox.AcceptsReturn = true;
            this._passTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._passTextBox.Location = new System.Drawing.Point(138, 67);
            this._passTextBox.MaxLength = 16;
            this._passTextBox.Name = "_passTextBox";
            this._passTextBox.PasswordChar = '*';
            this._passTextBox.Size = new System.Drawing.Size(190, 20);
            this._passTextBox.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 5, 6, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Повтор пароля:";
            // 
            // wizardPage4
            // 
            this.wizardPage4.Controls.Add(this.label15);
            this.wizardPage4.Name = "wizardPage4";
            this.wizardPage4.Size = new System.Drawing.Size(331, 177);
            this.wizardPage4.Text = "Завершение активации";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Завершение активации, ждите...";
            // 
            // ActivationWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(337, 242);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(342, 145);
            this.Name = "ActivationWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Активация";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.wizardPage3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.wizardPage4.ResumeLayout(false);
            this.wizardPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox _regKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _messageLabel;
        private ITTrust.UI.Common.WizardControl wizardControl1;
        private ITTrust.UI.Common.WizardPage wizardPage1;
        private ITTrust.UI.Common.WizardPage wizardPage2;
        private ITTrust.UI.Common.WizardPage wizardPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button _forwardButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox _addressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _cityComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _phoneTextBox;
        private System.Windows.Forms.TextBox _emailTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox _pass2TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _loginTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox _passTextBox;
        private System.Windows.Forms.Label label14;
        private ITTrust.UI.Common.WizardPage wizardPage4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}