using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NLog;
using DbLib;

namespace SQLiteClient
{
    public partial class EssencesForm : Form
    {
        // Список сущностей
        List<string> lsEssences = new List<string>();

        Logger logger = LogManager.GetCurrentClassLogger();
        

        public EssencesForm()
        {
            InitializeComponent();
        }

        // Метод загрузки сущностей
        private void EssencesForm_Load(object sender, EventArgs e)
        {
            // Очистка списка предыдущих сущностей
            lsbEssences.Items.Clear();

            // Получаем список сущностей
            lsEssences = DbMain.GetEssences();

            // Заполняем список
            for (int i = 0; i < lsEssences.Count; i++)
            {
                if (lsEssences[i] != "sqlite_sequence")
                    lsbEssences.Items.Add(lsEssences[i]);
            }

            // Пишем лог
            logger.Info("Essences count: " + (lsEssences.Count - 1));

        }

        // Метод вызова окна редактирования таблицы
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Если выбрана сушность
            if (lsbEssences.SelectedIndex >= 0)
            {
                // Вызываем окно 
                using (EditForm frEdit = new EditForm())
                {
                    // Передаём окну имя сущности
                    frEdit.Text = lsbEssences.SelectedItem.ToString();

                    // Ожидаем получения результата
                    if (frEdit.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
            else
            {
                // Сообщение об ошибке
                MessageBox.Show("Выберите изменяемую сущность",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
