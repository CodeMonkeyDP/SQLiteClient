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
    public partial class EditForm : Form
    {
        private List<string> colNames = new List<string>();
        private List<Field> Fields = new List<Field>();
        private object prevValue = null;

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            Fields.Clear();
            colNames.Clear();
            tblFields.Columns.Clear();

            DbMain.GetColNames(Text, Fields);
            for (int i = 0; i < Fields.Count; i++)
            {
                tblFields.Columns.Add("Column" + (i + 1), Fields[i].FieldName);
            }

            colNames = DbMain.GetDataFromTable(Text);


            if (colNames.Count > 0)
            {
                for (int i = 0; i < colNames.Count / tblFields.Columns.Count; i++)
                {
                    tblFields.Rows.Add();
                    for (int j = 0; j < tblFields.Columns.Count; j++)
                    {
                        tblFields[j, i].Value = colNames[i * tblFields.Columns.Count + j];
                    }
                }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tblFields.SelectedRows.Count > 0)
            {
                DbMain.RemoveData(Text, Fields[0], tblFields[0, tblFields.SelectedRows[0].Index].Value.ToString());
                EditForm_Load(sender, e);
            }
            else
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // int nIndex = tblFields.Rows.Add();
            using (AddNewForm frmAdd = new AddNewForm())
            {
                frmAdd.Text = this.Text;
                frmAdd.SetColumns(Fields);

                if (frmAdd.ShowDialog() == DialogResult.Yes)
                {
                    EditForm_Load(sender, e);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //// Проверка на пустое значение
            //for (int i = 0; i < Fields.Count; i++)
            //{
            //    if (Fields[i].NotNull)
            //    {
            //        for (int j = 0; j < tblFields.Rows.Count; j++)
            //        {
            //            if (tblFields[i, j].Value == null || tblFields[i, j].Value == "")
            //            {
            //                MessageBox.Show("Значение поля не может быть пустым (" + i + " столбец, " + j + " строка).",
            //                                "Ошибка",
            //                                MessageBoxButtons.OK,
            //                                MessageBoxIcon.Warning);
            //                return;
            //            }
            //        }
            //    }
            //}

            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message,
            //                    "Ошибка",
            //                    MessageBoxButtons.OK,
            //                    MessageBoxIcon.Warning);
            //}
        }

        private void tblFields_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            prevValue = tblFields[e.ColumnIndex, e.RowIndex].Value;
        }

        private void tblFields_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            prevValue = tblFields[e.ColumnIndex, e.RowIndex].Value;
        }

        private void tblFields_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && tblFields[e.ColumnIndex, e.RowIndex].Value != null)
            {
                try
                {
                    DbMain.EditData(Fields[e.ColumnIndex], 
                                    Text, 
                                    tblFields[e.ColumnIndex, e.RowIndex].Value.ToString(), 
                                    Convert.ToInt32(tblFields[0, e.RowIndex].Value));
                }
                catch (Exception ex)
                {
                    tblFields[e.ColumnIndex, e.RowIndex].Value = prevValue;
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                tblFields[e.ColumnIndex, e.RowIndex].Value = prevValue;
            }
        }
    }
}
