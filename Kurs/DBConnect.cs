using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Data;
using Kurs.Connection;

namespace Kurs
{
    public class DataBase 
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-Q1SCM8R; Initial Catalog=NoMercy; Integrated Security=True");

        public void openConnection()
        {
            if(SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
        public bool AuthUser(string loginUser, string passwordUser)
        {
            loginUser = md5l.Hashlog(loginUser);
            passwordUser = md5.HashPassword(passwordUser);
            DataBase database = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querrystring = $"select id_user, login_user, password_user from register where login_user='{loginUser}'and password_user='{passwordUser}'";
            SqlCommand command = new SqlCommand(querrystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
