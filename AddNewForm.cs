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
    public partial class AddNewForm : Form
    {
        private List<Field> Fields = new List<Field>();
        private List<string> lsData = new List<string>();
        public AddNewForm()
        {
            InitializeComponent();
        }

        public void SetColumns(List<Field> fields)
        {
            Fields = fields;

            for (int i = 0; i < fields.Count; i++)
            {
                tblNewField.Columns.Add("Column" + (i + 1), fields[i].FieldName);
            }

            tblNewField.Rows.Add();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            lsData.Clear();

            for (int i = 0; i < Fields.Count; i++)
            {
                if (Fields[i].NotNull && (tblNewField[i, 0].Value == null || tblNewField[i, 0].Value == ""))
                {
                    MessageBox.Show("Значение " + tblNewField.Columns[i].HeaderText + " не может быть пустым.",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
            }

            for (int i = 0; i < tblNewField.Columns.Count; i++)
            {
                lsData.Add(tblNewField[i, 0].Value.ToString());
            }
            try
            {
                DbMain.InsertData(Text, Fields, lsData);

                DialogResult = DialogResult.Yes;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
