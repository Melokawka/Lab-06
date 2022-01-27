using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            float currentSize = lblOut.Font.Size;
            
            lblOut.Font = new Font(lblOut.Font.Name, currentSize,
                lblOut.Font.Style, lblOut.Font.Unit);
            if (rdbSmall.Checked == true) currentSize -= 2.0F;
            else if(rdbBig.Checked == true) currentSize += 2.0F;
            else if (rdbLarge.Checked == true) currentSize += 4.0F;

            if (checBold.Checked == true) lblOut.Font = new Font(this.Font,FontStyle.Bold);
            else if (checItalic.Checked == true) lblOut.Font = new Font(this.Font, FontStyle.Italic);
            else if (checUnderL.Checked == true) lblOut.Font = new Font(this.Font, FontStyle.Underline);
            
            if (rdbRed.Checked == true) lblOut.ForeColor=Color.Red;
            else if (rdbBlue.Checked == true) lblOut.ForeColor = Color.Blue;
            else if (rdbOrange.Checked == true) lblOut.ForeColor = Color.DarkOrange;

            lblOut.Font = new Font(this.Font.Name, currentSize, this.Font.Style);
            lblOut.Text = lblIn.Text;
        }
    }
}
