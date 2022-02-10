using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
                new Student(){ imie="Michal",nazwisko="Jacek",nrIndeksu=34562,wydzial="KIS"}
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

        
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("data.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //foreach (Student student in ListaStudentow.ToList())
            //{
            //    sw.WriteLine("[[Student]]");
            //    sw.WriteLine("[FirstName]");
            //    sw.WriteLine(student.imie);
            //    sw.WriteLine("[SurName]");
            //    sw.WriteLine(student.nazwisko);
            //    sw.WriteLine("[StudentNo]");
            //    sw.WriteLine(student.nrIndeksu);
            //    sw.WriteLine("[Faculty]");
            //    sw.WriteLine(student.wydzial);
            //    sw.WriteLine("[[]]");
            //}
            //    sw.Close();
            foreach(Student student in ListaStudentow)
                Save(student,sw);
            sw.Close();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            List<Student> nowaLista = new();
            Student stud = new();
            try
            {
                FileStream fs = new FileStream("data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                { 
                    var ln = sr.ReadLine();
                    while (!sr.EndOfStream && ln.ToArray()[0] == '[') ln = sr.ReadLine();
                    stud.imie = ln;
                    ln = sr.ReadLine();
                    while (!sr.EndOfStream && ln.ToArray()[0] == '[') ln = sr.ReadLine();
                    stud.nazwisko = ln;
                    ln = sr.ReadLine();
                    while (!sr.EndOfStream && ln.ToArray()[0] == '[') ln = sr.ReadLine();
                    Debug.WriteLine(ln);
                    stud.nrIndeksu = Int32.Parse(ln.ToString());
                    ln = sr.ReadLine();
                    while (!sr.EndOfStream && ln.ToArray()[0] == '[') ln = sr.ReadLine();
                    stud.wydzial = ln;
                    ln = sr.ReadLine();

                    nowaLista.Add(stud);
                    stud = new();
                }
                sr.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Błąd odczytu");
            }
            ListaStudentow.Clear();
            ListaStudentow.AddRange(nowaLista);
            dgStudent.Items.Refresh();
            MessageBox.Show("Udało się");
        }
        void Save<T>(T ob, System.IO.StreamWriter sw)
        {
            Type t = ob.GetType();
            sw.WriteLine($"[[{t.FullName}]]");
            foreach (var p in t.GetProperties())
            {
                sw.WriteLine($"[{p.Name}]");
                sw.WriteLine(p.GetValue(ob));
            }
            sw.WriteLine($"[[]]");
        }
    }
}
