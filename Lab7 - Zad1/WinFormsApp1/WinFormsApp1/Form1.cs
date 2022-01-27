using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("a waga?");
            else if (radioButton1.Checked == true)
            {
                if (checkBox1.Checked == true) label4.Text = ((Convert.ToInt32(textBox1.Text) - 100) * 0.85).ToString();
                else if (checkBox2.Checked == true) label4.Text = (Convert.ToInt32(textBox1.Text) - 100).ToString();
                else MessageBox.Show("zaznacz rodzaj wagi");
            }
            else if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true) label4.Text = ((Convert.ToInt32(textBox1.Text) - 100) * 0.9).ToString();
                else if (checkBox2.Checked == true) label4.Text = (Convert.ToInt32(textBox1.Text) - 100).ToString();
                else MessageBox.Show("zaznacz rodzaj wagi");
            }
            else MessageBox.Show("zaznacz płeć!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
