using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 5)
            {
                label1.Visible = false;
            }
            else 
            {
                label1.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox2.Text, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
            {
                label4.Visible = false;
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void checkBoxs_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                label7.Visible = false;
            }
            else
            {
                label7.Visible = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label7.Visible || label4.Visible || label1.Visible)
            {
                label8.Text = "Invalid Registeration";
                label8.ForeColor = Color.Red;
                
            }
            else
            {
                label8.Text = "Thank You. Your Registration Is Valid";
                label8.ForeColor = Color.Green;
            }
        }

       
    }
}
