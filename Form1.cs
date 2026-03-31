using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(richTextBox1.Text);
            int b = Convert.ToInt32(richTextBox2.Text);
            string item = listBox1.SelectedItem.ToString();


            if (item == "+")
            {
                label1.Text = (a + b).ToString();
            }
            if (item == "-")
            {
                label1.Text = (a - b).ToString();
            }
            if (item == "/")
            {
                label1.Text = (a / b).ToString();
            }
            if (item == "*")
            {
                label1.Text = (a * b).ToString();
                {
                }
            }
        }
    }
}
