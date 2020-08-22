using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteClient
{
    public static class DbMain
    {
        private const string strConnection = "Data Source = ComputersDB.db; Version=3";
        private static SQLiteConnection dbConnection = new SQLiteConnection(strConnection);
        private static SQLiteCommand sqlCommand;
        private static SQLiteDataReader sqlDataReader;
        private static List<string> lsEssences = new List<string>();
        private static StringBuilder sb = new StringBuilder();


        public static void ConnectToDb()
        {
            dbConnection.Open();            
        }

        public static void EndConnection()
        {
            dbConnection.Close();
        }

        public static bool FindAdmin(string strLogin, string strPassword)
        {
            bool bSuccess = false;

            sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = "select * from Admins where Name like '%' || @login || '%' and Password like '%' || @password || '%' ";
            sqlCommand.Parameters.Add("@login", System.Data.DbType.String).Value = strLogin;
            sqlCommand.Parameters.Add("@password", System.Data.DbType.String).Value = strPassword;
            sqlDataReader = sqlCommand.ExecuteReader();

            // Если найден только один пароль
            if (sqlDataReader.HasRows)
                bSuccess = true;

            return bSuccess;
        }

        public static List<string> GetEssences()
        {
            lsEssences.Clear();

            sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM sqlite_master WHERE type='table';";
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    lsEssences.Add((string)sqlDataReader["tbl_name"]);
                }
            }

            return lsEssences;
        }

        public static void AddEssence(string essenceName, List<Field> fields)
        {
            sb.Clear();

            sb.Append("CREATE TABLE ");
            sb.Append(essenceName);
            sb.Append(" ( ");
            for (int i = 0; i < fields.Count; i++)
            {
                sb.Append(fields[i].FieldName);
                sb.Append(" ");
                sb.Append(fields[i].FieldType);
                if (fields[i].HasSize)
                {
                    sb.Append(" (");
                    sb.Append(fields[i].Size);
                    if (fields[i].HasAccuracy)
                    {
                        sb.Append(", ");
                        sb.Append(fields[i].Accuracy);
                    }
                    sb.Append(")");
                }
                sb.Append(" ");
                if (fields[i].ForeignKey)
                {
                    sb.Append("REFERENCES ");
                    sb.Append(fields[i].ForeignTable);
                    sb.Append(" (");
                    sb.Append(fields[i].ForeignField);
                    sb.Append(") ");
                }
                if (fields[i].NotNull)
                {
                    sb.Append("NOT NULL");
                }
                if (fields[i].Uniq)
                {
                    sb.Append("UNIQUE");
                }
                if (i < fields.Count - 1)
                    sb.Append(",");
            }
            sb.Append(");");

            sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = sb.ToString();

            sqlCommand.ExecuteReader();
        }

        public static List<string> GetColNames(string tableName)
        {
            lsEssences.Clear();

            sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = "pragma table_info(" + tableName+ ")";
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    lsEssences.Add((string)sqlDataReader["name"]);
                }
            }

            return lsEssences;
        }

        public static void RemoveTable(string tableName)
        {
            sqlCommand = dbConnection.CreateCommand();
            sqlCommand.CommandText = "DROP TABLE " + tableName + ";";
            sqlDataReader = sqlCommand.ExecuteReader();
        }
    }
}
