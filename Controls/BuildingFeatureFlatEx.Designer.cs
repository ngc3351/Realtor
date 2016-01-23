namespace Realtor.Controls
{
    partial class BuildingFeatureFlatEx
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
            this.label6 = new System.Windows.Forms.Label();
            this._materialComboBox = new System.Windows.Forms.ComboBox();
            this._floursComboBox = new System.Windows.Forms.ComboBox();
            this._seriesComboBox = new System.Windows.Forms.ComboBox();
            this._newCheckBox = new System.Windows.Forms.CheckBox();
            this._liveCheckBox = new System.Windows.Forms.CheckBox();
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
            this.groupBox2.Size = new System.Drawing.Size(274, 146);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики здания";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this._materialComboBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this._floursComboBox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this._seriesComboBox, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this._newCheckBox, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this._liveCheckBox, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(268, 127);
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
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Этажей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Планировка";
            // 
            // _materialComboBox
            // 
            this._materialComboBox.DisplayMember = "Value";
            this._materialComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._materialComboBox.FormattingEnabled = true;
            this._materialComboBox.Location = new System.Drawing.Point(78, 3);
            this._materialComboBox.Name = "_materialComboBox";
            this._materialComboBox.Size = new System.Drawing.Size(187, 21);
            this._materialComboBox.TabIndex = 1;
            this._materialComboBox.Tag = "Material";
            this._materialComboBox.ValueMember = "Key";
            // 
            // _floursComboBox
            // 
            this._floursComboBox.DisplayMember = "Value";
            this._floursComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._floursComboBox.FormattingEnabled = true;
            this._floursComboBox.Location = new System.Drawing.Point(78, 30);
            this._floursComboBox.Name = "_floursComboBox";
            this._floursComboBox.Size = new System.Drawing.Size(187, 21);
            this._floursComboBox.TabIndex = 3;
            this._floursComboBox.Tag = "Flours";
            this._floursComboBox.ValueMember = "Key";
            // 
            // _seriesComboBox
            // 
            this._seriesComboBox.DisplayMember = "Value";
            this._seriesComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._seriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._seriesComboBox.FormattingEnabled = true;
            this._seriesComboBox.Location = new System.Drawing.Point(78, 57);
            this._seriesComboBox.Name = "_seriesComboBox";
            this._seriesComboBox.Size = new System.Drawing.Size(187, 21);
            this._seriesComboBox.TabIndex = 5;
            this._seriesComboBox.Tag = "Series";
            this._seriesComboBox.ValueMember = "Key";
            // 
            // _newCheckBox
            // 
            this._newCheckBox.AutoSize = true;
            this._newCheckBox.Location = new System.Drawing.Point(78, 84);
            this._newCheckBox.Name = "_newCheckBox";
            this._newCheckBox.Size = new System.Drawing.Size(136, 17);
            this._newCheckBox.TabIndex = 6;
            this._newCheckBox.Tag = "New";
            this._newCheckBox.Text = "Новое стройтельство";
            this._newCheckBox.UseVisualStyleBackColor = true;
            // 
            // _liveCheckBox
            // 
            this._liveCheckBox.AutoSize = true;
            this._liveCheckBox.Location = new System.Drawing.Point(78, 107);
            this._liveCheckBox.Name = "_liveCheckBox";
            this._liveCheckBox.Size = new System.Drawing.Size(90, 17);
            this._liveCheckBox.TabIndex = 7;
            this._liveCheckBox.Tag = "Live";
            this._liveCheckBox.Text = "Жилой фонд";
            this._liveCheckBox.UseVisualStyleBackColor = true;
            // 
            // BuildingFeatureFlatEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox2);
            this.Name = "BuildingFeatureFlatEx";
            this.Size = new System.Drawing.Size(274, 146);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _materialComboBox;
        private System.Windows.Forms.ComboBox _floursComboBox;
        private System.Windows.Forms.ComboBox _seriesComboBox;
        private System.Windows.Forms.CheckBox _newCheckBox;
        private System.Windows.Forms.CheckBox _liveCheckBox;
        private System.Windows.Forms.BindingSource objectBindingSource;
    }
}
