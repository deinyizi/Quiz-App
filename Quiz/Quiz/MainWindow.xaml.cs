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
using Quiz.Model;

namespace Quiz
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignupQuiz SNG = new SignupQuiz();
            SNG.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String username = usernameTextBox.Text;
            String password = passwordBox.Password;

            if (DBHelper.verifyUser(username, password))
            {
                User currentUser = DBHelper.getUser(username, password);
                SubjectPick subjectPick = new SubjectPick(currentUser);

                subjectPick.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WelcomeQuiz welcome = new WelcomeQuiz();
            this.Hide();
            welcome.Show();
        }
    }
}
