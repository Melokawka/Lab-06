using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class GradeWindow : Window
    {
        public Student student;
        public GradeWindow(Student student = null)
        {            
            InitializeComponent();
            if (student != null)
            {
                txtNr.Text = student.nrIndeksu.ToString();
                foreach (int ocena in student.listaOcen.ToList())
                {
                    txtOcena.Text += ocena.ToString() + " ";
                    Debug.WriteLine(ocena);
                }
            }
            this.student = student ?? new Student();

        }
        public GradeWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(txtOcena.Text, @"^([0-6]?\s?)+$"))
            {
                MessageBox.Show("Niepoprawne dane");
                return;
            }
            if (txtOcena.Text.Length == 1) student.listaOcen.Add(Int32.Parse(txtOcena.Text));
            else 
            {
                student.listaOcen.Clear();
                char[] array = txtOcena.Text.ToCharArray();
                for (int i = 0; i < txtOcena.Text.Length; i += 2)
                {
                    char c = array[i];                   
                    student.listaOcen.Add(c - '0');
                }
            }
            this.Close();
            //this.DialogResult = true;

        }
    }
}
