using System;
using System.Collections.Generic;
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
        public static List<Student> _students;
        public App() { }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //get data from storage
            if(_students == null)
            {
                // _students = new List<Student>();
                _students = GenerateStudents(30);
            }
        }

        private List<Student> GenerateStudents(int cnt)
        {
            var lst = new List<Student>();
            for (int i = 0; i < cnt; i++)
            {
                lst.Add(new Student
                {
                    firstName =
                    "fname" + i,
                    lastName = "lname" + i
                });
            }
            return lst;
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }
    }
}
