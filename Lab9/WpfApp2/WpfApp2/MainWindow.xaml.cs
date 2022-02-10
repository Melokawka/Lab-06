using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }
        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                new Student(){ imie="Jan",nazwisko="Kowalski",nrIndeksu=1234,wydzial="KIS"},
                new Student(){ imie="Anna",nazwisko="Nowak",nrIndeksu=4321,wydzial="KIS"},
                new Student(){ imie="Michał",nazwisko="Jacek",nrIndeksu=34562,wydzial="KIS"}
            };

            InitializeComponent();

            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Imię", Binding = new Binding("imie") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("nazwisko") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Numer indeksu", Binding = new Binding("nrIndeksu") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Wydział", Binding = new Binding("wydzial") });

            dgStudent.AutoGenerateColumns = false;
            dgStudent.ItemsSource = ListaStudentow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student st = new();
            Student student=null;
            Type ObjectType = dgStudent.SelectedItem.GetType();
            if (ObjectType.IsAssignableFrom(st.GetType())) student = (Student)dgStudent.SelectedItem;
            var dialog = new StudentWindow(student);
            if (student == null)
            {
                if(dialog.ShowDialog()==true)
                {
                    ListaStudentow.Add(dialog.student);
                    dgStudent.Items.Refresh();
                }
            }
            else if (dialog.ShowDialog() == true)
            {
                ListaStudentow.Remove(student);
                ListaStudentow.Add(dialog.student);
                dgStudent.Items.Refresh();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student)
                ListaStudentow.Remove((Student)dgStudent.SelectedItem);
            dgStudent.Items.Refresh();
        }

        private void btnAddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student)
            {
                Student student = (Student)dgStudent.SelectedItem;
                GradeWindow GradeWindow = new(student);
                GradeWindow.Show();
                //var dialog = new GradeWindow(student);
                //if (dialog.ShowDialog() == true) 
                //{
                    //foreach (int ocena in dialog.student.listaOcen.ToList())
                    //{
                        //student.listaOcen.Add(ocena);
                        //Debug.WriteLine(ocena);
                    //}
                //}
            }
        }

        private void btnShowGrades_Click(object sender, RoutedEventArgs e)
        {

            if (dgStudent.SelectedItem is Student)
            {            
                Student student = (Student)dgStudent.SelectedItem;
                string grades = "";
                foreach (int c in student.listaOcen.ToList()) grades+=c.ToString()+" ";
                MessageBox.Show(grades);
            }
        }
    }
}
