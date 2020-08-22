namespace SQLiteClient
{
    partial class AddFieldForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.nudAccuracy = new System.Windows.Forms.NumericUpDown();
            this.chbPrimKey = new System.Windows.Forms.CheckBox();
            this.chbForeignKey = new System.Windows.Forms.CheckBox();
            this.chbUnic = new System.Windows.Forms.CheckBox();
            this.chbNotNull = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCalcel = new System.Windows.Forms.Button();
            this.chbSize = new System.Windows.Forms.CheckBox();
            this.chbAccuracy = new System.Windows.Forms.CheckBox();
            this.cbEssences = new System.Windows.Forms.ComboBox();
            this.cbFields = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя столбца:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип данных:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(104, 20);
            this.tbName.TabIndex = 4;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(132, 30);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(101, 21);
            this.cbType.TabIndex = 5;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // nudSize
            // 
            this.nudSize.Enabled = false;
            this.nudSize.Location = new System.Drawing.Point(12, 171);
            this.nudSize.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(104, 20);
            this.nudSize.TabIndex = 6;
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // nudAccuracy
            // 
            this.nudAccuracy.Enabled = false;
            this.nudAccuracy.Location = new System.Drawing.Point(129, 171);
            this.nudAccuracy.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudAccuracy.Name = "nudAccuracy";
            this.nudAccuracy.Size = new System.Drawing.Size(104, 20);
            this.nudAccuracy.TabIndex = 7;
            this.nudAccuracy.ValueChanged += new System.EventHandler(this.nudAccuracy_ValueChanged);
            // 
            // chbPrimKey
            // 
            this.chbPrimKey.AutoSize = true;
            this.chbPrimKey.Location = new System.Drawing.Point(12, 56);
            this.chbPrimKey.Name = "chbPrimKey";
            this.chbPrimKey.Size = new System.Drawing.Size(111, 17);
            this.chbPrimKey.TabIndex = 8;
            this.chbPrimKey.Text = "Первичный ключ";
            this.chbPrimKey.UseVisualStyleBackColor = true;
            this.chbPrimKey.CheckedChanged += new System.EventHandler(this.chbPrimKey_CheckedChanged);
            // 
            // chbForeignKey
            // 
            this.chbForeignKey.AutoSize = true;
            this.chbForeignKey.Location = new System.Drawing.Point(12, 74);
            this.chbForeignKey.Name = "chbForeignKey";
            this.chbForeignKey.Size = new System.Drawing.Size(99, 17);
            this.chbForeignKey.TabIndex = 9;
            this.chbForeignKey.Text = "Внешний ключ";
            this.chbForeignKey.UseVisualStyleBackColor = true;
            this.chbForeignKey.CheckedChanged += new System.EventHandler(this.chbForeignKey_CheckedChanged);
            // 
            // chbUnic
            // 
            this.chbUnic.AutoSize = true;
            this.chbUnic.Location = new System.Drawing.Point(129, 56);
            this.chbUnic.Name = "chbUnic";
            this.chbUnic.Size = new System.Drawing.Size(99, 17);
            this.chbUnic.TabIndex = 10;
            this.chbUnic.Text = "Уникальность";
            this.chbUnic.UseVisualStyleBackColor = true;
            this.chbUnic.CheckedChanged += new System.EventHandler(this.chbUnic_CheckedChanged);
            // 
            // chbNotNull
            // 
            this.chbNotNull.AutoSize = true;
            this.chbNotNull.Location = new System.Drawing.Point(129, 74);
            this.chbNotNull.Name = "chbNotNull";
            this.chbNotNull.Size = new System.Drawing.Size(71, 17);
            this.chbNotNull.TabIndex = 11;
            this.chbNotNull.Text = "Не NULL";
            this.chbNotNull.UseVisualStyleBackColor = true;
            this.chbNotNull.CheckedChanged += new System.EventHandler(this.chbNotNull_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(12, 197);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCalcel
            // 
            this.btnCalcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalcel.Location = new System.Drawing.Point(129, 197);
            this.btnCalcel.Name = "btnCalcel";
            this.btnCalcel.Size = new System.Drawing.Size(104, 23);
            this.btnCalcel.TabIndex = 15;
            this.btnCalcel.Text = "Отмена";
            this.btnCalcel.UseVisualStyleBackColor = true;
            this.btnCalcel.Click += new System.EventHandler(this.btnCalcel_Click);
            // 
            // chbSize
            // 
            this.chbSize.AutoSize = true;
            this.chbSize.Location = new System.Drawing.Point(12, 148);
            this.chbSize.Name = "chbSize";
            this.chbSize.Size = new System.Drawing.Size(68, 17);
            this.chbSize.TabIndex = 16;
            this.chbSize.Text = "Размер:";
            this.chbSize.UseVisualStyleBackColor = true;
            this.chbSize.CheckedChanged += new System.EventHandler(this.chbSize_CheckedChanged);
            // 
            // chbAccuracy
            // 
            this.chbAccuracy.AutoSize = true;
            this.chbAccuracy.Location = new System.Drawing.Point(129, 148);
            this.chbAccuracy.Name = "chbAccuracy";
            this.chbAccuracy.Size = new System.Drawing.Size(76, 17);
            this.chbAccuracy.TabIndex = 17;
            this.chbAccuracy.Text = "Точность:";
            this.chbAccuracy.UseVisualStyleBackColor = true;
            this.chbAccuracy.CheckedChanged += new System.EventHandler(this.chbAccuracy_CheckedChanged);
            // 
            // cbEssences
            // 
            this.cbEssences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEssences.Enabled = false;
            this.cbEssences.FormattingEnabled = true;
            this.cbEssences.Location = new System.Drawing.Point(12, 121);
            this.cbEssences.Name = "cbEssences";
            this.cbEssences.Size = new System.Drawing.Size(104, 21);
            this.cbEssences.TabIndex = 18;
            this.cbEssences.SelectedIndexChanged += new System.EventHandler(this.cbEssences_SelectedIndexChanged);
            // 
            // cbFields
            // 
            this.cbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFields.Enabled = false;
            this.cbFields.FormattingEnabled = true;
            this.cbFields.Location = new System.Drawing.Point(129, 121);
            this.cbFields.Name = "cbFields";
            this.cbFields.Size = new System.Drawing.Size(104, 21);
            this.cbFields.TabIndex = 19;
            this.cbFields.SelectedIndexChanged += new System.EventHandler(this.cbFields_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Таблица:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Поле:";
            // 
            // AddFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 231);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFields);
            this.Controls.Add(this.cbEssences);
            this.Controls.Add(this.chbAccuracy);
            this.Controls.Add(this.chbSize);
            this.Controls.Add(this.btnCalcel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chbNotNull);
            this.Controls.Add(this.chbUnic);
            this.Controls.Add(this.chbForeignKey);
            this.Controls.Add(this.chbPrimKey);
            this.Controls.Add(this.nudAccuracy);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddFieldForm";
            this.Text = "AddFieldForm";
            this.Load += new System.EventHandler(this.AddFieldForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.NumericUpDown nudAccuracy;
        private System.Windows.Forms.CheckBox chbPrimKey;
        private System.Windows.Forms.CheckBox chbForeignKey;
        private System.Windows.Forms.CheckBox chbUnic;
        private System.Windows.Forms.CheckBox chbNotNull;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCalcel;
        private System.Windows.Forms.CheckBox chbSize;
        private System.Windows.Forms.CheckBox chbAccuracy;
        private System.Windows.Forms.ComboBox cbEssences;
        private System.Windows.Forms.ComboBox cbFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}