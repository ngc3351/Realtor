namespace Realtor.Controls
{
    partial class BuildingFeatureCottage
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._materialComboBox = new System.Windows.Forms.ComboBox();
            this._floursComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._newCheckBox = new System.Windows.Forms.CheckBox();
            this._liveCheckBox = new System.Windows.Forms.CheckBox();
            this._electricityComboBox = new System.Windows.Forms.ComboBox();
            this._hotComboBox = new System.Windows.Forms.ComboBox();
            this._waterComboBox = new System.Windows.Forms.ComboBox();
            this.objectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 203);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики здания";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this._materialComboBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this._floursComboBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this._newCheckBox, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this._liveCheckBox, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this._electricityComboBox, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this._hotComboBox, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this._waterComboBox, 2, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(284, 184);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Здание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Этажей";
            // 
            // _materialComboBox
            // 
            this.tableLayoutPanel4.SetColumnSpan(this._materialComboBox, 2);
            this._materialComboBox.DisplayMember = "Value";
            this._materialComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._materialComboBox.FormattingEnabled = true;
            this._materialComboBox.Location = new System.Drawing.Point(94, 1);
            this._materialComboBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this._materialComboBox.Name = "_materialComboBox";
            this._materialComboBox.Size = new System.Drawing.Size(187, 21);
            this._materialComboBox.TabIndex = 1;
            this._materialComboBox.Tag = "Material";
            this._materialComboBox.ValueMember = "Key";
            // 
            // _floursComboBox
            // 
            this.tableLayoutPanel4.SetColumnSpan(this._floursComboBox, 2);
            this._floursComboBox.DisplayMember = "Value";
            this._floursComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._floursComboBox.FormattingEnabled = true;
            this._floursComboBox.Location = new System.Drawing.Point(94, 24);
            this._floursComboBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this._floursComboBox.Name = "_floursComboBox";
            this._floursComboBox.Size = new System.Drawing.Size(187, 21);
            this._floursComboBox.TabIndex = 3;
            this._floursComboBox.Tag = "Flours";
            this._floursComboBox.ValueMember = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Электроснабжение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Теплоснабжение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Водоснабжение";
            // 
            // _newCheckBox
            // 
            this._newCheckBox.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this._newCheckBox, 2);
            this._newCheckBox.Location = new System.Drawing.Point(94, 118);
            this._newCheckBox.Name = "_newCheckBox";
            this._newCheckBox.Size = new System.Drawing.Size(136, 17);
            this._newCheckBox.TabIndex = 10;
            this._newCheckBox.Tag = "New";
            this._newCheckBox.Text = "Новое стройтельство";
            this._newCheckBox.UseVisualStyleBackColor = true;
            // 
            // _liveCheckBox
            // 
            this._liveCheckBox.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this._liveCheckBox, 2);
            this._liveCheckBox.Location = new System.Drawing.Point(94, 141);
            this._liveCheckBox.Name = "_liveCheckBox";
            this._liveCheckBox.Size = new System.Drawing.Size(90, 17);
            this._liveCheckBox.TabIndex = 11;
            this._liveCheckBox.Tag = "Live";
            this._liveCheckBox.Text = "Жилой фонд";
            this._liveCheckBox.UseVisualStyleBackColor = true;
            // 
            // _electricityComboBox
            // 
            this._electricityComboBox.DisplayMember = "Value";
            this._electricityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._electricityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._electricityComboBox.FormattingEnabled = true;
            this._electricityComboBox.Location = new System.Drawing.Point(114, 47);
            this._electricityComboBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this._electricityComboBox.Name = "_electricityComboBox";
            this._electricityComboBox.Size = new System.Drawing.Size(167, 21);
            this._electricityComboBox.TabIndex = 5;
            this._electricityComboBox.Tag = "Electricity";
            this._electricityComboBox.ValueMember = "Key";
            // 
            // _hotComboBox
            // 
            this._hotComboBox.DisplayMember = "Value";
            this._hotComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._hotComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._hotComboBox.FormattingEnabled = true;
            this._hotComboBox.Location = new System.Drawing.Point(114, 70);
            this._hotComboBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this._hotComboBox.Name = "_hotComboBox";
            this._hotComboBox.Size = new System.Drawing.Size(167, 21);
            this._hotComboBox.TabIndex = 7;
            this._hotComboBox.Tag = "Hot";
            this._hotComboBox.ValueMember = "Key";
            // 
            // _waterComboBox
            // 
            this._waterComboBox.DisplayMember = "Value";
            this._waterComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._waterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._waterComboBox.FormattingEnabled = true;
            this._waterComboBox.Location = new System.Drawing.Point(114, 93);
            this._waterComboBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this._waterComboBox.Name = "_waterComboBox";
            this._waterComboBox.Size = new System.Drawing.Size(167, 21);
            this._waterComboBox.TabIndex = 9;
            this._waterComboBox.Tag = "Water";
            this._waterComboBox.ValueMember = "Key";
            // 
            // BuildingFeatureCottage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox2);
            this.Name = "BuildingFeatureCottage";
            this.Size = new System.Drawing.Size(290, 203);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _materialComboBox;
        private System.Windows.Forms.ComboBox _floursComboBox;
        private System.Windows.Forms.CheckBox _newCheckBox;
        private System.Windows.Forms.CheckBox _liveCheckBox;
        private System.Windows.Forms.BindingSource objectBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _electricityComboBox;
        private System.Windows.Forms.ComboBox _hotComboBox;
        private System.Windows.Forms.ComboBox _waterComboBox;
    }
}
