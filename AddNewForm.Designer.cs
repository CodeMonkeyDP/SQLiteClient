namespace SQLiteClient
{
    partial class AddNewForm
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
            this.tblNewField = new System.Windows.Forms.DataGridView();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnRefuse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblNewField)).BeginInit();
            this.SuspendLayout();
            // 
            // tblNewField
            // 
            this.tblNewField.AllowUserToAddRows = false;
            this.tblNewField.AllowUserToDeleteRows = false;
            this.tblNewField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblNewField.Location = new System.Drawing.Point(13, 13);
            this.tblNewField.Name = "tblNewField";
            this.tblNewField.RowHeadersVisible = false;
            this.tblNewField.Size = new System.Drawing.Size(775, 104);
            this.tblNewField.TabIndex = 0;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(13, 123);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(361, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Применить";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnRefuse
            // 
            this.btnRefuse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefuse.Location = new System.Drawing.Point(427, 123);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(361, 23);
            this.btnRefuse.TabIndex = 2;
            this.btnRefuse.Text = "Отмена";
            this.btnRefuse.UseVisualStyleBackColor = true;
            // 
            // AddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 154);
            this.Controls.Add(this.btnRefuse);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.tblNewField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewForm";
            this.Text = "AddNewForm";
            ((System.ComponentModel.ISupportInitialize)(this.tblNewField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblNewField;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnRefuse;
    }
}