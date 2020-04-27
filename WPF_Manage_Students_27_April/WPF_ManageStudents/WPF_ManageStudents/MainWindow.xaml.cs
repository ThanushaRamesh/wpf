using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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
        string language;
        bool firstTime;
        public MainWindow()
        {
            language = Properties.Settings.Default.language;
            firstTime = true;
            CultureInfo.CurrentCulture = new CultureInfo(language);
            CultureInfo.CurrentUICulture = new CultureInfo(language);

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
            Cobx_Picked.ItemsSource = new List<bool> { true, false };

            var lst = new List<string> { "de Deutsch", "en English" };
            CoBox_Lang.ItemsSource = lst;



            var itm = (from l in lst where l.Contains(language) select l).FirstOrDefault();
            CoBox_Lang.SelectedItem = itm;
        }

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();
            var lst = from s in App._students where s.name.ToLower().Contains(filter) select s;
            Lbx_Students.ItemsSource = lst;

        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Student stud = new Student { firstName = "Edit...", lastName = "Edit...", matNumber = Math.Abs(Guid.NewGuid().GetHashCode()).ToString() };


            App._students.Add(stud);
            Lbx_Students.SelectedItem = stud;
            Lbx_Students.ScrollIntoView(stud);  // scrolled to the new student


            //Workaround
            //Lbx_Students.ItemsSource = null;
            //Lbx_Students.ItemsSource =App._students


        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var itm = Lbx_Students.SelectedItem;

            if (itm == null)
            {
                MessageBox.Show("Please select an itm to be deleted first!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var toDelete = itm as Student;

            var res = MessageBox.Show($"Are you sure to delete {toDelete.firstName} {toDelete.lastName}?", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (res == MessageBoxResult.OK)
                App._students.Remove(toDelete);
        }



        private void Btn_GoToWindow_Click(object sender, RoutedEventArgs e)
        {
            var win = new W_Test();
            win.Owner = this;
            Visibility = Visibility.Hidden;
            win.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var lst = from s in App._students where s.gender == "f"  select s;

            //sorting
            var lst = App._students.OrderBy(s => s.firstName);
            Lbx_Students.ItemsSource = lst;

        }

        private void CoBox_Lang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (firstTime)
            {
                firstTime = false;
                return;
            }



            language = CoBox_Lang.SelectedItem.ToString().Substring(0, 2);    //from 0, first two characters fetch
            Properties.Settings.Default.language = language;
            Properties.Settings.Default.Save();
            Process.Start(Application.ResourceAssembly.Location);
            App.Current.Shutdown();  //kill running one
        
        }

     

        private void Btn_Nx_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void Btn_pr_Click(object sender, RoutedEventArgs e)
        {
            var pos = Lbx_Students.SelectedIndex;
            pos--;
            if (pos < 0)
            {
                pos = 0;
                Lbx_Students.SelectedIndex = pos;                
            }

        }
    }
}
