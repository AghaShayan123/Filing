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

namespace File_Write
{
    public partial class Form1 : Form
    {
        String[] ext = { ".txt", ".doc", ".dll"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background2;
            this.Text = "Stream Writer";
            this.label1.Text = "Text Write";
            this.label2.Text = "Source";
            this.label3.Text = "Destination";
            this.label4.Text = "Extension";
            this.button1.Text = "Save";
            this.button2.Text = "Stream";
            this.button3.Text = "Clear";
            this.button4.Text = "Exit";
            this.comboBox1.Items.AddRange(ext);
            Color color = ColorTranslator.FromHtml("#E81123");
            this.button4.BackColor = color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.comboBox1.Text="";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String n = this.textBox2.Text + this.textBox3.Text + comboBox1.Text;
            StreamWriter sw = new StreamWriter(n);
            MessageBox.Show("File already Exists");
            sw.Write(this.textBox1.Text.ToCharArray());
            MessageBox.Show("File Write");
            sw.Close();   
        }
    }
}
