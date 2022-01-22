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
using System.Windows.Shapes;
using Quiz.Model;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for SuccessQuizPage.xaml
    /// </summary>
    public partial class SuccessQuizPage : Window
    {
        public SuccessQuizPage()
        {
            InitializeComponent();
        }

        int score;
        int count;
        User currentUser;
        public SuccessQuizPage(int score, int count, User currentUser)
        {
            InitializeComponent();

            this.currentUser = currentUser;

            this.score = score;
            this.count = count;

            scoreTextBox_.Text = "Score " + (score + "") + "/" + (count + "");

            double percentage = (score * 100.0) / count;

            if (percentage >= 80.0)
            {
                gradeBox.Text = "Congratulations, your score was Excellent!";
            }
            else if (percentage >= 70.0)
            {
                gradeBox.Text = "Congratulations, your score was Good!";
            }
            else if (percentage >= 50)
            {
                gradeBox.Text = "Congrats, your score was good but can be better";
            }
            else
            {
                gradeBox.Text = "You can do better!";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SubjectPick subjectPick = new SubjectPick(currentUser);
            this.Hide();
            subjectPick.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SubjectPick subjectPick = new SubjectPick(currentUser);
            this.Hide();
            subjectPick.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
