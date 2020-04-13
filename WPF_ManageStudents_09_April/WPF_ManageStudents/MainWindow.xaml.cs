using System;
using System.Collections.Generic;
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

namespace WPF_ManageStudents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btn_Hello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("We managed to do it");
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lbx_Students.ItemsSource = App._students;
            CoBx_gender.ItemsSource = App._genders;
        }

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();
            var lst = from s in App._students where s.lastName.ToLower().Contains(filter) select s;
            Lbx_Students.ItemsSource = lst;

        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Student stud = new Student { firstName = "Edit...", lastName = "Edit...", matNumber = Math.Abs(Guid.NewGuid().GetHashCode()).ToString()};


            App._students.Add(stud);
            Lbx_Students.SelectedItem = stud;
            Lbx_Students.ScrollIntoView(stud);  // scrolled to the new student


            //Workaround
            //Lbx_Students.ItemsSource = null;
            //Lbx_Students.ItemsSource =App._students

            
        }
    }
}
