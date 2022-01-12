using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        static double pierwsza=0;
        static double druga;
        static string dzialanie="+";
        static bool wyczysc=false;
        static bool znakrownosci=false;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CzyWyczyscic();
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dzialanie = "+";
            druga = double.Parse(textBox1.Text);
            WykonajDzialanie();
            wyczysc = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pierwsza = 0;
            druga = 0;

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            druga = double.Parse(textBox1.Text);
            WykonajDzialanie();
            wyczysc = true;
            dzialanie = null;
            znakrownosci = true;
        }

        private void WykonajDzialanie()
        {
            if (dzialanie != null && druga != null)
            {
                if (dzialanie == "+") pierwsza+=druga;
                else if (dzialanie == "*") pierwsza*=druga;
                else if (dzialanie == "-") pierwsza-=druga;
                else if (dzialanie == "/") pierwsza/=druga;
            }
            textBox1.Text = Convert.ToString(pierwsza);
        }

        private void CzyWyczyscic()
        {
            if (wyczysc == true) textBox1.Clear();
            if (znakrownosci == true)
            {
                pierwsza = 0;
                znakrownosci = false;
                dzialanie = null;
            }
            wyczysc = false;
        }
    }
}
