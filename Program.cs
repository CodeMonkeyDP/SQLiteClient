using System;
using System.Windows.Forms;
using DbLib;

namespace SQLiteClient
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Подключение к БД
            DbMain.ConnectToDb();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EssencesForm());

            // Закрытие подключения к БД
            DbMain.EndConnection();
        }
    }
}
