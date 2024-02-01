using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Connection;

namespace Kurs
{
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser=textBox1.Text;
            string passwordUser=textBox2.Text;
            DataBase database = new DataBase();
            bool _isAuth = false;
            _isAuth = database.AuthUser(loginUser, passwordUser);
            
            if (_isAuth == true) 
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Visiner visin = new Visiner();
                this.Hide();
                visin.ShowDialog();

            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!","Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regist frm_regist = new regist();
            frm_regist.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
