using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public  string Text_Font { get; set; }
        //public  string Text { get ; set; }
        public string TextBoxx { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public  float Text_Size { get; set; } = 12;
        public Form1()
        {
            InitializeComponent();
            

        }
        public Form1(string text)
        {
            InitializeComponent();
            textBox1.Text = text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox1.Text);
           

            this.Hide();
            form2.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Font font = new Font(Text_Font, Text_Size);
            textBox1.Font = font;
        }
    }
}
