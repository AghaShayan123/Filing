using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Compare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage= Properties.Resources.background2;
            this.Text = "Compare Files";
            this.label1.Text = "Source 1";
            this.label2.Text = "File Name 1";
            this.label3.Text = "Source 2";
            this.label4.Text = "File Name 2";
            this.button1.Text = "Compare";
            this.button2.Text = "Clear";
            this.button3.Text = "Exit";
            this.button1.BackColor = Color.AliceBlue;
            this.button2.BackColor = Color.AliceBlue;
            this.button3.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sd1 = new StreamReader(this.textBox1.Text+this.textBox2.Text);
            StreamReader sd2 = new StreamReader(this.textBox3.Text + this.textBox4.Text);
            String i = sd1.ReadToEnd();
            String j = sd2.ReadToEnd();
            if (i == j)
            {
                MessageBox.Show("File Same");
            }
            else
            {
                MessageBox.Show("Not Same");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
