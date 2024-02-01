using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Kurs.Connection;



namespace Kurs
{
    public partial class regist : Form
    {
        DataBase dataBase = new DataBase();
        public regist()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void regist_Load(object sender, EventArgs e)
        {
            textBox22.PasswordChar = '*';
            textBox12.MaxLength = 50;
            textBox22.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            var login = md5l.Hashlog( textBox12.Text);
            var password = md5.HashPassword(textBox22.Text);

            string querystring = $"insert into register(login_user, password_user) values ('{login}', '{password}')";

            if (checkuser()) { return; }

            SqlCommand comand = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.openConnection();
            if(comand.ExecuteNonQuery()==1) 
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            
            dataBase.closeConnection();
        }
        private Boolean checkuser()
        {
            var logUser = md5l.Hashlog(textBox12.Text);
            var passUser = md5.HashPassword(textBox22.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user ='{logUser}'and password_user='{passUser}'";
            SqlCommand comand = new SqlCommand(querystring, dataBase.GetConnection());
            adapter.SelectCommand = comand;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else { return false; }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void regist_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void regist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
