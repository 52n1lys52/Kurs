using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs.Connection;

namespace Kurs
{
    public partial class Coding : Form
    {
        public Coding()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visiner visiner = new Visiner();
            this.Hide();
            visiner.Show();
        }

        private void Coding_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string keyword = textBox2.Text;
            ClassEncode Encoded = new ClassEncode();
            textBox3.Text = Encoded.Encode(input, keyword);
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Coding_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = ".txt";
            savefile.Filter = "Test files|*.txt";
            if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK && savefile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName, true))
                {
                    sw.WriteLine(textBox3.Text);
                    sw.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog readfile = new OpenFileDialog();
            if (readfile.ShowDialog() == DialogResult.OK)
            {
                Name = readfile.FileName;
                textBox1.Clear();

                textBox1.Text = File.ReadAllText(Name);

            }
        }
    }
}

