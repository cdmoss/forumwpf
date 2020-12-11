using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows;

namespace Reddit_Prototype.Classes
{
    public class DatabaseReader
    {

        string connString = $"Data source=Users.sqlite;Version=3";

        string createTable = $"create table Users(" +
            $"ID integer primary key autoincrement, " +
            $"Username text not null," +
            $"Password text not null," +
            $"Email text not null," +
            $"Karma text not null)";

        string databaseName = "Users.sqlite";

        SQLiteConnection conn;
        SQLiteCommand cmd;

        public DatabaseReader()
        {
            conn = new SQLiteConnection(connString);

            if (!File.Exists(databaseName))
            {
                SQLiteConnection.CreateFile(databaseName);
                CreatTable();
            }
        }

        private void CreatTable()
        {
            cmd = new SQLiteCommand(createTable, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void addUser(string username, string password, string email, int karma)
        {
            string query = $"insert into Users" +
                $"(Username, Password, Email, Karma) " +
                $"values(" +
                $"'{username}', " +
                $"'{password}', " +
                $"'{email}', " +
                $"{karma})";

            cmd = new SQLiteCommand(query, conn);

            try
            {
                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public bool checkLogin(string username, string password)
        {
            bool connected = false;

            string query = $"select Username, Password " +
                $"from Users";
            
            try
            {
                conn.Open();

                using (cmd = new SQLiteCommand(query, conn))
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        string pass = reader.GetString(1);
                        if(name == username && password == pass)
                        {
                            connected = true;
                            return connected;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return connected;
        }

        public string getEmail(string acctname)
        {
            string ret = null;

            string query = $"select Email " +
                $"from Users " +
                $"where Username = '{acctname}'";

            try
            {
                conn.Open();

                using (cmd = new SQLiteCommand(query, conn))
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string email = reader.GetString(0);

                        ret = email;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return ret;
        }


    }
}
