using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITE314_2ndProject_Manzon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Search;
            Search = int.Parse(textBox1.Text);
            if (Search == 1)
            {
                textBox2.Text = "APPLE";
                textBox3.Text = "100";
                textBox4.Text = "50.00";
            }
            else if (Search == 2)
            {
                textBox2.Text = "GRAPES";
                textBox3.Text = "50";
                textBox4.Text = "70.00";
            }
            else if (Search == 3)
            {
                textBox2.Text = "BANANA";
                textBox3.Text = "90";
                textBox4.Text = "35.00";
            }
            else if (Search == 4)
            {
                textBox2.Text = "MANGO";
                textBox3.Text = "200";
                textBox4.Text = "25.00";
            }
            else if (Search == 5)
            {
                textBox2.Text = "PINEAPPLE";
                textBox3.Text = "80";
                textBox4.Text = "60.00";
            }
            else
            {
                textBox2.Text = "Invalid";
                textBox3.Text = "Invalid";
                textBox4.Text = "Invalid";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox5.Text);
                double b = Convert.ToDouble(textBox4.Text);
                textBox6.Text = (a * b + 13.25).ToString();
                textBox7.Text = "13.25";
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox8.Text);
            double b = Convert.ToDouble(textBox6.Text);
            textBox9.Text = (a - b).ToString();
        }
    }
}
