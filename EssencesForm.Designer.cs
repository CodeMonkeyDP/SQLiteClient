namespace SQLiteClient
{
    partial class EssencesForm
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
            this.lsbEssences = new System.Windows.Forms.ListBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbEssences
            // 
            this.lsbEssences.FormattingEnabled = true;
            this.lsbEssences.Location = new System.Drawing.Point(12, 12);
            this.lsbEssences.Name = "lsbEssences";
            this.lsbEssences.Size = new System.Drawing.Size(288, 394);
            this.lsbEssences.TabIndex = 0;
            this.lsbEssences.SelectedIndexChanged += new System.EventHandler(this.lsbEssences_SelectedIndexChanged);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(12, 412);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(287, 39);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Редактировать поля";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // EssencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 466);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.lsbEssences);
            this.Name = "EssencesForm";
            this.Text = "EssencesForm";
            this.Load += new System.EventHandler(this.EssencesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbEssences;
        private System.Windows.Forms.Button BtnEdit;
    }
}