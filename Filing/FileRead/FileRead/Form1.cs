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

namespace FileRead
{
    public partial class Form1 : Form
    {
        String[] exten = {".txt", ".exe", ".docx", ".pdf", ".html", ".jpeg"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Source";
            this.label2.Text = "Directory";
            this.label3.Text = "Extension";
            this.label4.Text = "Output";
            this.button1.Text = "Read / FileStream";
            this.button2.Text = "Stream Reader";
            this.comboBox1.Items.AddRange(exten);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fn = textBox1.Text + textBox2.Text + comboBox1.Text;
            FileStream fs = new FileStream(@fn, FileMode.Open);

            byte[] bb = new byte[100];
            char[] cc = new char[100];
            fs.Read(bb, 0, 100);
            Decoder de = Encoding.UTF8.GetDecoder();
            de.GetChars(bb, 0, bb.Length, cc, 0);

            foreach (char c in cc)
            {
                this.textBox3.Text += c;
            }
            this.textBox3.ScrollBars = ScrollBars.Both;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fn = textBox1.Text + textBox2.Text + comboBox1.Text;
            StreamReader sd = new StreamReader(@"E:\abc.txt");

            textBox3.Text = sd.ReadToEnd();
            sd.Close();

        }

    }
}
