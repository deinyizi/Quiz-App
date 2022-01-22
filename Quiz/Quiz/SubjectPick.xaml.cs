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
using System.Windows.Shapes;
using Quiz.Model;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for SubjectPick.xaml
    /// </summary>
    public partial class SubjectPick : Window
    {
        public SubjectPick()
        {
            InitializeComponent();
        }

        User currentUser;
        public SubjectPick(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            welcomeTextBox.Text = "Welcome " + currentUser.Username;
        }

        private void btnSearch_MouseDown(object sender, MouseEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void showInstructions(List<Question> questions, string subject)
        {
            if (questions.Count == 0)
            {
                MessageBox.Show("There are no questions for this subject yet");
                return;
            }
            QuizInstruction quizInstruction = new QuizInstruction(questions, currentUser, subject);
            quizInstruction.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Question> questions = DBHelper.getQuestions((String) geographyButton.Content);
            showInstructions(questions, "GEOGRAPHY");
        }

        private void historyButton_Click_1(object sender, RoutedEventArgs e)
        {
            List<Question> questions = DBHelper.getQuestions((String) historyButton.Content);
            showInstructions(questions, "HISTORY");
        }

        private void biologyButton_Click_1(object sender, RoutedEventArgs e)
        {
            List<Question> questions = DBHelper.getQuestions((String) biologyButton.Content);
            showInstructions(questions, "BIOLOGY");
        }

        private void currentAffairButton_Click_1(object sender, RoutedEventArgs e)
        {
            List<Question> questions = DBHelper.getQuestions((String) currentAffairButton.Content);
            showInstructions(questions, "CURRENT AFFAIRS");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Hide();
            mw.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
