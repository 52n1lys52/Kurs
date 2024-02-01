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

namespace Kurs
{
    public partial class Visiner : Form
    {
        public Visiner()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Visiner_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coding frm_cod = new Coding();
            this.Hide();
            frm_cod.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decoding frm_decod = new Decoding();
            frm_decod.Show();
            this.Hide();
        }

        private void Visiner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
