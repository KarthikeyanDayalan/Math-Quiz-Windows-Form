using System;
using System.Windows.Forms;

namespace Multiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random randomizer = new Random();

        public int Value1 { set { label1.Text = value.ToString(); } }
        public int Value2 { set { label2.Text = value.ToString(); } }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int val,count = 0 ;
            if (int.TryParse(textBox1.Text, out val))
            {
                if (textBox1.Text != "" && Convert.ToInt32(label1.Text) * Convert.ToInt32(label2.Text) == Convert.ToInt32(textBox1.Text))
                {
                    if (count > 25)
                    {
                        label3.Text = "Bronze Medalist";
                    }
                    else if (count > 50)
                    {
                        label3.Text = "Silver Medalist";
                    }
                    else if (count > 100)
                    {
                        label3.Text = "Gold Medalist";
                    }
                    else
                    {
                        label3.Text = "Correct!! Solve this one";
                    }
                    count++;
                    textBox1.Text = "";
                }
                else
                {
                    label3.Text = "Oops!! Solve this one";
                    textBox1.Text = "";
                }
            }
            else
            {
                label3.Text = "Enter Number in output field";
                textBox1.Text = "";
            }
            label1.Text = randomizer.Next(50).ToString();
            label2.Text = randomizer.Next(50).ToString();
            textBox1.Focus();
        }
    }
}
