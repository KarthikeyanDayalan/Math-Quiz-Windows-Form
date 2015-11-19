using System;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        Addition.Form1 aform;
        Subtraction.Form1 sform;
        Multiplication.Form1 mform;
        Division.Form1 dform;
        FormCollection fc;

        public Form1()
        {
            InitializeComponent();
        }

        Random randomize = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            aform = new Addition.Form1();
            aform.Value1 = randomize.Next(99);
            aform.Value2 = randomize.Next(99);
            aform.Show();

            fc = Application.OpenForms;

            foreach (var item in fc)
            {
                if(item.Equals(sform))
                {
                    sform.Hide();
                }
                else if (item.Equals(mform))
                {
                    mform.Hide();
                }
                else if (item.Equals(dform))
                {
                    dform.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            sform = new Subtraction.Form1();
            sform.Value1 = randomize.Next(99);
            sform.Value2 = randomize.Next(99);
            sform.Show();
            fc = Application.OpenForms;

            foreach (var item in fc)
            {
                if(item.Equals(aform))
                {
                    aform.Hide();
                }
                else if (item.Equals(mform))
                {
                    mform.Hide();
                }
                else if (item.Equals(dform))
                {
                    dform.Hide();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mform = new Multiplication.Form1();
            mform.Value1 = randomize.Next(99);
            mform.Value2 = randomize.Next(99);
            mform.Show();
            fc = Application.OpenForms;

            foreach (var item in fc)
            {
                if (item.Equals(sform))
                {
                    sform.Hide();
                }
                else if (item.Equals(aform))
                {
                    aform.Hide();
                }
                else if (item.Equals(dform))
                {
                    dform.Hide();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dform = new Division.Form1();
            dform.Value1 = randomize.Next(99);
            dform.Value2 = randomize.Next(99);
            dform.Show();
            fc = Application.OpenForms;

            foreach (var item in fc)
            {
                if (item.Equals(sform))
                {
                    sform.Hide();
                }
                else if (item.Equals(mform))
                {
                    mform.Hide();
                }
                else if (item.Equals(aform))
                {
                    aform.Hide();
                }
            }
        }
    }
}
