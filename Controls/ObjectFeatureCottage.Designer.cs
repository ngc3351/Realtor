namespace Realtor.Controls
{
    partial class ObjectFeatureCottage
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
            this.objectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this._flatsComboBox = new System.Windows.Forms.ComboBox();
            this._phoneCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this._pravaComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this._wcComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this._mebelCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.tableLayoutPanel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(379, 316);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Характеристики объекта";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this._flatsComboBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this._phoneCheckBox, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this._pravaComboBox, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this._wcComboBox, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox2, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this._mebelCheckBox, 3, 6);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(373, 297);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Кол-во комнат";
            // 
            // _flatsComboBox
            // 
            this.tableLayoutPanel5.SetColumnSpan(this._flatsComboBox, 3);
            this._flatsComboBox.DisplayMember = "Value";
            this._flatsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flatsComboBox.FormattingEnabled = true;
            this._flatsComboBox.Location = new System.Drawing.Point(118, 3);
            this._flatsComboBox.MaxLength = 2;
            this._flatsComboBox.Name = "_flatsComboBox";
            this._flatsComboBox.Size = new System.Drawing.Size(252, 21);
            this._flatsComboBox.TabIndex = 1;
            this._flatsComboBox.Tag = "Flats";
            this._flatsComboBox.ValueMember = "Key";
            // 
            // _phoneCheckBox
            // 
            this._phoneCheckBox.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this._phoneCheckBox, 2);
            this._phoneCheckBox.Location = new System.Drawing.Point(118, 136);
            this._phoneCheckBox.Name = "_phoneCheckBox";
            this._phoneCheckBox.Size = new System.Drawing.Size(71, 17);
            this._phoneCheckBox.TabIndex = 16;
            this._phoneCheckBox.Tag = "Phone";
            this._phoneCheckBox.Text = "Телефон";
            this._phoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Права на землю";
            // 
            // _pravaComboBox
            // 
            this.tableLayoutPanel5.SetColumnSpan(this._pravaComboBox, 3);
            this._pravaComboBox.DisplayMember = "Value";
            this._pravaComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pravaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._pravaComboBox.FormattingEnabled = true;
            this._pravaComboBox.Location = new System.Drawing.Point(118, 82);
            this._pravaComboBox.Name = "_pravaComboBox";
            this._pravaComboBox.Size = new System.Drawing.Size(252, 21);
            this._pravaComboBox.TabIndex = 13;
            this._pravaComboBox.Tag = "Prava";
            this._pravaComboBox.ValueMember = "Key";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 109);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Санузел";
            // 
            // _wcComboBox
            // 
            this.tableLayoutPanel5.SetColumnSpan(this._wcComboBox, 3);
            this._wcComboBox.DisplayMember = "Value";
            this._wcComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._wcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._wcComboBox.FormattingEnabled = true;
            this._wcComboBox.Location = new System.Drawing.Point(118, 109);
            this._wcComboBox.Name = "_wcComboBox";
            this._wcComboBox.Size = new System.Drawing.Size(252, 21);
            this._wcComboBox.TabIndex = 15;
            this._wcComboBox.Tag = "WC";
            this._wcComboBox.ValueMember = "Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Площ. общая";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(118, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Tag = "SqAll";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(223, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Жилая";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(271, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Tag = "SqHome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Площ. земли, кв. м.";
            // 
            // textBox3
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.textBox3, 3);
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(118, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Tag = "SqLand";
            // 
            // _mebelCheckBox
            // 
            this._mebelCheckBox.AutoSize = true;
            this._mebelCheckBox.Location = new System.Drawing.Point(271, 136);
            this._mebelCheckBox.Name = "_mebelCheckBox";
            this._mebelCheckBox.Size = new System.Drawing.Size(65, 17);
            this._mebelCheckBox.TabIndex = 17;
            this._mebelCheckBox.Tag = "Mebel";
            this._mebelCheckBox.Text = "Мебель";
            this._mebelCheckBox.UseVisualStyleBackColor = true;
            // 
            // ObjectFeatureCottage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox5);
            this.Name = "ObjectFeatureCottage";
            this.Size = new System.Drawing.Size(379, 316);
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource objectBindingSource;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _flatsComboBox;
        private System.Windows.Forms.CheckBox _phoneCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox _pravaComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox _wcComboBox;
        private System.Windows.Forms.CheckBox _mebelCheckBox;
        private System.Windows.Forms.Label label1;
    }
}
