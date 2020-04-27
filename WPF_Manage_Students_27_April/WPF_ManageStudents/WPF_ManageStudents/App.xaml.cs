using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_ManageStudents
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<Student> _students;
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public static List<string> _genders = new List<string> { "m", "f", "d" };

        public App() { }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

            //get data from storage
            _students = MyStorage.ReadXML<ObservableCollection<Student>>("students.xml");

            if (_students == null)
            {
                _students = new ObservableCollection<Student>();
                //_students = GenerateStudents(50);
            }
        }

        private ObservableCollection<Student> GenerateStudents(int cnt)
        {
            List<string> fNames = new List<string> { "Bhavana", "Shivani", "Thanusha", "Priya", "Pallavi", "Divya", "Ram", "Bheem", "Nakul", "Sahadeva", "Lakshman" };
            List<string> lNames = new List<string> { "Blname", "Slname", "Tlname", "Plname", "Dlname", "Rlname", "Bhlname", "Nlname", "Shname", "Llnmae" };
            var lst = new ObservableCollection<Student>();
            for (int i = 0; i < cnt; i++)
            {
                int fNo = rnd.Next(fNames.Count);
                int lNo = rnd.Next(lNames.Count);
                var gndr = fNo > 5 ? "m" : "f";

                lst.Add(new Student
                {
                    firstName = fNames[fNo],
                    lastName = lNames[lNo],
                    gender = gndr,
                    matNumber = Math.Abs(Guid.NewGuid().GetHashCode()).ToString()
                });
            }
            return lst;
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            //Mystorage- Class..WriteXML method, <>type
            MyStorage.WriteXml<ObservableCollection<Student>>(_students, "students.xml");

        }
    }
}
