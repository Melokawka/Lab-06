using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);
                float z = float.Parse(textBox3.Text);
                textBox4.Text = (x+y+z).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Podano błędne dane","Uwaga!",MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);
                float z = float.Parse(textBox3.Text);
                textBox4.Text = (x * y * z).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
