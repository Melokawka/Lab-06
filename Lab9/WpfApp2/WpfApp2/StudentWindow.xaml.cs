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
    public partial class StudentWindow : Window
    {
        public Student student;
        public StudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                tbImie.Text = student.imie;
                tbNazwisko.Text = student.nazwisko;
                tbNrAlbumu.Text = student.nrIndeksu.ToString();
                tbWydzial.Text = student.wydzial;
            }
            this.student = student ?? new Student();
        }

        public StudentWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(tbImie.Text, @"^[a-zA-Z]+$") ||
               !Regex.IsMatch(tbNazwisko.Text, @"^[a-zA-Z]+$") ||
               !Regex.IsMatch(tbWydzial.Text, @"^[a-zA-Z]+$") ||
               !Regex.IsMatch(tbNrAlbumu.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Podano niepoprawne dane!");
                return;
            }
            student.imie = tbImie.Text;
            student.nazwisko = tbNazwisko.Text;
            student.nrIndeksu = Int32.Parse(tbNrAlbumu.Text);
            student.wydzial = tbWydzial.Text;
            this.DialogResult = true;
        }
    }
}
