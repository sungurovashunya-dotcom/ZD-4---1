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
            if (!double.TryParse(richTextBox1.Text, out double degrees))
            {
                label1.Text = "Ошибка ввода числа";
                return;
            }
            double radians = degrees * Math.PI / 180.0;
            double result = 0.0;
            string item = listBox1.SelectedItem.ToString();
            if (item == "sin")
            {
                result = Math.Sin(radians);
            }
            else if (item == "cos")
            {
                result = Math.Cos(radians);
            }
            else if (item == "tg")
            {
                result = Math.Tan(radians);
            }
            label1.Text = result.ToString();
        }
    }
}
