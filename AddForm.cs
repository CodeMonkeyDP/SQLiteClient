using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteClient
{
    public partial class AddForm : Form
    {
        private StringBuilder builder = new StringBuilder();
        private List<Field> fields = new List<Field>();
        public string EssenceName { get { return tbName.Text; } }
        public List<Field> EssenceFields { get { return fields; } }

        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            using (AddFieldForm affForm = new AddFieldForm())
            {
                if (affForm.ShowDialog(this) == DialogResult.OK)
                {
                    int nIndex = tblFields.Rows.Add();
                    // Пишем данные по полученному индексу
                    tblFields[0, nIndex].Value = affForm.Field.FieldName;
                    tblFields[1, nIndex].Value = affForm.Field.FieldType;
                    tblFields[2, nIndex].Value = affForm.Field.PrimaryKey;
                    tblFields[3, nIndex].Value = affForm.Field.ForeignKey;
                    tblFields[4, nIndex].Value = affForm.Field.Uniq;
                    tblFields[5, nIndex].Value = affForm.Field.NotNull;
                    SetSizeAndAccurancy(affForm.Field, tblFields[1, nIndex]);

                    fields.Add(affForm.Field);
                }
            }

            btnOk.Enabled = (tbName.Text != null && tbName.Text != "" && tblFields.Rows.Count > 0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tblFields.SelectedRows.Count > 0)
            {
                int nIndex = tblFields.SelectedRows[0].Index;
                using (AddFieldForm affForm = new AddFieldForm())
                {
                    affForm.SetValues(fields[nIndex]);

                    if (affForm.ShowDialog(this) == DialogResult.OK)
                    {
                        // Пишем данные по полученному индексу
                        tblFields[0, nIndex].Value = affForm.Field.FieldName;
                        tblFields[1, nIndex].Value = affForm.Field.FieldType;
                        tblFields[2, nIndex].Value = affForm.Field.PrimaryKey;
                        tblFields[3, nIndex].Value = affForm.Field.ForeignKey;
                        tblFields[4, nIndex].Value = affForm.Field.Uniq;
                        tblFields[5, nIndex].Value = affForm.Field.NotNull;
                        SetSizeAndAccurancy(affForm.Field, tblFields[1, nIndex]);

                        fields[nIndex] = affForm.Field;
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tblFields.SelectedRows.Count > 0)
            {
                int nIndex = tblFields.SelectedRows[0].Index;
                fields.RemoveAt(nIndex);
                tblFields.Rows.RemoveAt(nIndex);
            }
            btnOk.Enabled = (tbName.Text != null && tbName.Text != "" && tblFields.Rows.Count > 0);
        }

        private void SetSizeAndAccurancy(Field field, DataGridViewCell cell)
        {
            builder.Clear();
            builder.Append(cell.Value.ToString().Trim());
            if (field.HasSize)
            {
                builder.Append(" (");
                builder.Append(field.Size);
                if (field.HasAccuracy)
                {
                    builder.Append(", ");
                    builder.Append(field.Accuracy);
                }
                builder.Append(")");
            }
            cell.Value = builder.ToString();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = (tbName.Text != null && tbName.Text != "" && tblFields.Rows.Count > 0);
        }
    }
}
