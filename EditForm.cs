using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NLog;
using DbLib;

namespace SQLiteClient
{
    public partial class EditForm : Form
    {
        // Список значений
        private List<string> colNames = new List<string>();

        // Список полей
        private List<Field> Fields = new List<Field>();

        // Предыдущее значение
        private object prevValue = null;

        // Логгер
        Logger logger = LogManager.GetCurrentClassLogger();

        public EditForm()
        {
            InitializeComponent();
        }

        // Метод обновления таблицы
        private void UpdateTable(object sender, EventArgs e)
        {
            // Очищаем список полей
            Fields.Clear();

            // Очищаем список значений
            colNames.Clear();

            // Очищаем столбцы
            tblFields.Columns.Clear();

            // Получаем список имён столбцов из БД
            DbMain.GetColNames(Text, Fields);

            // Создаём столбцы
            for (int i = 0; i < Fields.Count; i++)
            {
                tblFields.Columns.Add("Column" + (i + 1), Fields[i].FieldName);
            }

            // Получаем список значений
            colNames = DbMain.GetDataFromTable(Text);

            // Если список значений не пустой
            if (colNames.Count > 0)
            {
                for (int i = 0; i < colNames.Count / tblFields.Columns.Count; i++)
                {
                    // Добавляем строчки
                    tblFields.Rows.Add();

                    // Заполняем таблицу
                    for (int j = 0; j < tblFields.Columns.Count; j++)
                    {
                        tblFields[j, i].Value = colNames[i * tblFields.Columns.Count + j];
                    }
                }
            }

        }

        // Метод удаления строки
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Если строка выбрана
            if (tblFields.SelectedRows.Count > 0)
            {
                // Удаляем строку
                DbMain.RemoveData(Text, Fields[0], tblFields[0, tblFields.SelectedRows[0].Index].Value.ToString());

                // Пишем лог
                logger.Info("Removed " + tblFields[0, tblFields.SelectedRows[0].Index].Value.ToString() + " from TABLE " + Text);

                // Обновляем таблицу
                UpdateTable(sender, e);
            }
        }

        // Метод добавления строки
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Открываем форму добавления
            using (AddNewForm frmAdd = new AddNewForm())
            {
                // Передаём имя таблицы в форму добавления
                frmAdd.Text = Text;

                // Передаём имена колонок
                frmAdd.SetColumns(Fields);
                
                // Если результат добавления положительный, обновляем таблицу
                if (frmAdd.ShowDialog() == DialogResult.Yes)
                {
                    UpdateTable(sender, e);
                }
            }
        }

        // Метод сохранения предыдущего значения ячейки
        private void tblFields_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            prevValue = tblFields[e.ColumnIndex, e.RowIndex].Value;
        }

        // Метод изменения значения ячейки
        private void tblFields_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Если выбранная ячейка не id и значение не пустое
            if (e.ColumnIndex != 0 && tblFields[e.ColumnIndex, e.RowIndex].Value != null)
            {
                try
                {
                    // Изменяем значение ячейки
                    DbMain.EditData(Fields[e.ColumnIndex], 
                                    Text, 
                                    tblFields[e.ColumnIndex, e.RowIndex].Value.ToString(), 
                                    Convert.ToInt32(tblFields[0, e.RowIndex].Value));

                    // Записываем лог
                    logger.Info("Данные (" + tblFields.Columns[e.ColumnIndex].HeaderText + ", " + "id: " + tblFields[0, e.RowIndex].Value.ToString() + ") изменены успешно");
                }
                catch (Exception ex)
                {
                    // Восстанавливаем предыдущее значение
                    tblFields[e.ColumnIndex, e.RowIndex].Value = prevValue;

                    // Выводим ошибку
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Записываем лог
                    logger.Error("Ошибка: " + ex.Message);
                }
            }
            else
            {
                // Восстанавливаем предыдущее значение
                tblFields[e.ColumnIndex, e.RowIndex].Value = prevValue;

                // Выводим ошибку
                logger.Warn("Изменение значений первичного ключа запрещено.");
            }
        }
    }
}
