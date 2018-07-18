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

namespace FileSearch
{
    public partial class Form1 : Form
    {
        String[] ext = { "*.exe", "*.xls", "*.html", "*.docx" ,"*.txt"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Directory Address";
            this.label2.Text = "Directory Name";
            this.label3.Text = "Extensions";
            this.button1.Text = "Ok";
            this.button2.Text = "Clear";
            this.comboBox1.Items.AddRange(ext);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s=this.textBox1.Text +"\\"+ this.textBox2.Text;
           // if (File.Exists(s))
            //{
                DirectoryInfo dir = new DirectoryInfo(s);
                FileInfo[] fi = dir.GetFiles(comboBox1.Text);
                foreach (FileInfo f in fi)
                {
                    this.textBox3.Text += f.Name + Environment.NewLine;
                }
            /*}
            else
            {
                this.textBox3.Text = "File Not Found";
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.comboBox1.Text = "";
        }
    }
}
