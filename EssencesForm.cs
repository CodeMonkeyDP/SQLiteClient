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
    public partial class EssencesForm : Form
    {
        List<string> lsEssences = new List<string>();
        

        public EssencesForm()
        {
            InitializeComponent();
        }

        private void EssencesForm_Load(object sender, EventArgs e)
        {
            lsbEssences.Items.Clear();
            lsEssences = DbMain.GetEssences();
            for (int i = 1; i < lsEssences.Count; i++)
            {
                lsbEssences.Items.Add(lsEssences[i]);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (AddForm frAdd = new AddForm())
            {
                if (frAdd.ShowDialog() == DialogResult.OK)
                {
                    DbMain.AddEssence(frAdd.EssenceName, frAdd.EssenceFields);
                    EssencesForm_Load(sender, e);
                }
            }
            
        }

        private void lsbEssences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lsbEssences.SelectedIndex >= 0)
            {

            }
            else
            {
                MessageBox.Show("Выберите изменяемую сущность", 
                                "Ошибка", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
            }
        }

        private void BntRemove_Click(object sender, EventArgs e)
        {
            if (lsbEssences.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранную сущность?", 
                                    "Удаление сущности", 
                                    MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DbMain.RemoveTable(lsbEssences.SelectedItem.ToString());
                    EssencesForm_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Выберите изменяемую сущность", 
                                "Ошибка", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
            }
        }
    }
}
