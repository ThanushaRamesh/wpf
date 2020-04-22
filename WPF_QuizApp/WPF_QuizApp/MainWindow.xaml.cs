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

namespace WPF_QuizApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Question question;
        public MainWindow()
        {
            InitializeComponent();
        }       


        private void Btn_newQuestion_Click(object sender, RoutedEventArgs e)
        {
            question = new Question { id = 0, qText = " asdgsfg sf gfdsg sgdsggf dsgdsfgdfsg fdgfd" };
            question.answers.Add(new Answer
            {
                aText = "0 ans text false",
                isCorrect = false
            });
            question.answers.Add(new Answer
            {
                aText = "1 ans text false",
                isCorrect = false
            });

            question.answers.Add(new Answer
            {
                aText = "2 ans text false",
                isCorrect = true
            });

            question.answers.Add(new Answer
            {
                aText = "3 ans text false",
                isCorrect = false
            });

            DataContext = question;


        }

        private void Lbx_Seletion(object sender, SelectionChangedEventArgs e)
        {
            var ans = (sender as ListBox).SelectedItem as Answer;

            if (ans.isCorrect)
            {
                MessageBox.Show("Correct Answer!!Congratulations");
            }
            else                          
            {
                MessageBox.Show("Incorrect Answer!!");
            }


        }
    }
}
