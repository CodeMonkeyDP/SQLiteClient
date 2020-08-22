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
    public partial class AddFieldForm : Form
    {
        //public string FieldName { get { return tbName.Text; } }
        //public string FieldType { get { return cbType.Text; } }
        List<string> lsEssences = new List<string>();

        // Возвращаемое значение поля
        public Field Field { get; set; }

        object[] vars = {"BIGINT",
                        "BLOB",
                        "BOOLEAN",
                        "CHAR",
                        "DATE",
                        "DATETIME",
                        "DECIMAL",
                        "DOUBLE",
                        "INTEGER",
                        "INT",
                        "NONE",
                        "NUMERIC",
                        "REAL",
                        "STRING",
                        "TEXT",
                        "TIME",
                        "VARCHAR"};

        public AddFieldForm()
        {
            InitializeComponent();
            Field = new Field();
            cbType.DataSource = vars;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (tbName.Text != null && tbName.Text != "");
            Field.FieldName = tbName.Text;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Field.FieldType = cbType.Text;
        }

        private void chbSize_CheckedChanged(object sender, EventArgs e)
        {
            Field.HasSize = chbSize.Checked;
            nudSize.Enabled = chbSize.Checked;
        }

        private void chbAccuracy_CheckedChanged(object sender, EventArgs e)
        {
            Field.HasAccuracy = chbAccuracy.Checked;
            nudAccuracy.Enabled = chbAccuracy.Checked;
        }
        
        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            Field.Size = nudSize.Value;
        }

        private void nudAccuracy_ValueChanged(object sender, EventArgs e)
        {
            Field.Accuracy = nudAccuracy.Value;
        }

        private void chbPrimKey_CheckedChanged(object sender, EventArgs e)
        {
            Field.PrimaryKey = chbPrimKey.Checked;
        }

        private void chbUnic_CheckedChanged(object sender, EventArgs e)
        {
            Field.Uniq = chbUnic.Checked;
        }

        private void chbForeignKey_CheckedChanged(object sender, EventArgs e)
        {
            Field.ForeignKey = chbForeignKey.Checked;
            cbEssences.Enabled = chbForeignKey.Checked;
            cbFields.Enabled = chbForeignKey.Checked;
        }

        private void chbNotNull_CheckedChanged(object sender, EventArgs e)
        {
            Field.NotNull = chbNotNull.Checked;
        }

        public void SetValues(Field field)
        {
            Field = field;
            tbName.Text = field.FieldName;
            cbType.Text = field.FieldType;
            
            chbForeignKey.Checked = field.ForeignKey;
            chbNotNull.Checked = field.NotNull;
            chbPrimKey.Checked = field.PrimaryKey;
            chbUnic.Checked = field.Uniq;

            chbAccuracy.Checked = field.HasAccuracy;
            if (chbAccuracy.Checked)
                nudAccuracy.Value = field.Accuracy;

            chbSize.Checked = field.HasSize;
            if (chbSize.Checked)
                nudSize.Value = field.Size;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcel_Click(object sender, EventArgs e)
        {

        }

        private void AddFieldForm_Load(object sender, EventArgs e)
        {
            List<string> lsAllEssences = DbMain.GetEssences();
            for (int i = 1; i < lsAllEssences.Count; i++)
            {
                lsEssences.Add(lsAllEssences[i]);
            }
            cbEssences.DataSource = lsEssences;
        }

        private void cbEssences_SelectedIndexChanged(object sender, EventArgs e)
        {
            Field.ForeignTable = cbEssences.Text;
            lsEssences = DbMain.GetColNames(cbEssences.Text);

            cbFields.Items.Clear();

            for (int i = 0; i < lsEssences.Count; i++)
                cbFields.Items.Add(lsEssences[i]);

            cbFields.SelectedIndex = 0;
        }

        private void cbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            Field.ForeignField = cbFields.Text;
        }
    }
}
