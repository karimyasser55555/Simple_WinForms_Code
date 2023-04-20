using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(string checkedItems in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox2.Items.Add(checkedItems);
                checkedListBox1.Items.Remove(checkedItems);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            foreach (string checkedItems in checkedListBox1.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox2.Items.Add(checkedItems);
                checkedListBox1.Items.Remove(checkedItems);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string checkedItems in checkedListBox2.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox1.Items.Add(checkedItems);
                checkedListBox2.Items.Remove(checkedItems);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, true);
            }
            foreach (string checkedItems in checkedListBox2.CheckedItems.OfType<string>().ToList())
            {
                checkedListBox1.Items.Add(checkedItems);
                checkedListBox2.Items.Remove(checkedItems);
            }
        }
    }
}
