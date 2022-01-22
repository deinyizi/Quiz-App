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
    /// Interaction logic for QuizInstruction.xaml
    /// </summary>
    public partial class QuizInstruction : Window
    {
        public QuizInstruction()
        {
            InitializeComponent();
        }

        List<Question> questions;
        User currentUser;
        public QuizInstruction(List<Question> questions, User currentUser, string subject)
        {
            InitializeComponent();
            this.questions = questions;
            this.currentUser = currentUser;
            welcomeTextBox.Text = "WELCOME TO " + subject + " QUIZ.";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            QuizPage quiz = new QuizPage(questions, currentUser);
            quiz.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubjectPick subjectPick = new SubjectPick(currentUser);
            this.Hide();
            subjectPick.Show();
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
