using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NLog;
using DbLib;

namespace SQLiteClient
{
    public partial class AddNewForm : Form
    {
        // Список полей
        private List<Field> Fields = new List<Field>();

        // Список значений
        private List<string> lsData = new List<string>();

        // Логгер
        Logger logger = LogManager.GetCurrentClassLogger();

        public AddNewForm()
        {
            InitializeComponent();
        }

        // Метод установки имен и названий столбцов
        public void SetColumns(List<Field> fields)
        {
            // Сохраняем список полей
            Fields = fields;

            // Создаём столбцы
            for (int i = 0; i < fields.Count; i++)
            {
                tblNewField.Columns.Add("Column" + (i + 1), fields[i].FieldName);
            }

            // Добавляем строку для заполнения данных
            tblNewField.Rows.Add();
        }

        // Метод записи результата
        private void btnYes_Click(object sender, EventArgs e)
        {
            // Очищаем список строк
            lsData.Clear();

            // Цикл проверки на пустые поля
            for (int i = 0; i < Fields.Count; i++)
            {
                // Проверяем на нулевое значение
                if (Fields[i].NotNull && (tblNewField[i, 0].Value == null || tblNewField[i, 0].Value.ToString() == ""))
                {
                    // Выводим ошибку, если нулевое значение
                    MessageBox.Show("Значение " + tblNewField.Columns[i].HeaderText + " не может быть пустым.",
                                    "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
            }

            // Заполняем список строк
            for (int i = 0; i < tblNewField.Columns.Count; i++)
            {
                lsData.Add(tblNewField[i, 0].Value.ToString());
            }
            try
            {
                // Вызываем метод добавления данных
                DbMain.InsertData(Text, Fields, lsData);

                // Устанавливаем возвращаемый родительскому окну результат
                DialogResult = DialogResult.Yes;

                // Пишем лог
                logger.Info("Новая строка в таблицу " + Text + " добавлена успешно");

                // Закрываем окно
                Close();
            }
            catch (Exception ex)
            {
                // Выводим ошибку
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Пишем лог
                logger.Error("Ошибка: " + ex.Message);
                return;
            }
        }
    }
}
