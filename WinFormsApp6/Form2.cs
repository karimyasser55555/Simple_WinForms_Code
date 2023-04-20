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
    public partial class Form2 : Form
    {
        //Form1 FormTest = new Form1();
        public string BoxText { get; set; }
        public Form2()
        {
            InitializeComponent();
            //FormTest.Show();
            //this.Hide();
        }
        public Form2(string text)
        {
            InitializeComponent();
            BoxText = text;
            //FormTest.Show();
            //this.Hide();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.Text_Font = comboBox1.SelectedItem.ToString();
            //Form1.Text_Size = (float)numericUpDown1.Value;
            

            //if (comboBox1.SelectedIndex >= 0)
            //    textBox1.ForeColor = (Color)comboBox1.SelectedValue;
            //form1.Text_Font = comboBox1.SelectedText;

            //    form1.Text_Size = (float)numericUpDown1.Value;
            this.DialogResult = DialogResult.OK;
            this.Hide();
            Form1 form1 = new Form1(BoxText);

            form1.Text_Font = comboBox1.SelectedItem.ToString();
            form1.Text_Size = (float)numericUpDown1.Value;
            form1.Show();
            //FormTest.Text_Font = comboBox1.SelectedItem.ToString();
            //FormTest.Text_Size = (float)numericUpDown1.Value;
            //FormTest.TextBoxx = BoxText;
            //FormTest.textBox1.Font  = new Font(comboBox1.SelectedItem.ToString(), (float)numericUpDown1.Value);
        }

    }
}
