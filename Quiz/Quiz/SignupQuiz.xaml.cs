using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for SignupQuiz.xaml
    /// </summary>
    public partial class SignupQuiz : Window
    {
        SqlConnection conn;

        public SignupQuiz()
        {
            InitializeComponent();
        }

        public static bool isValidEmail(String email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String username = usernameTextBox.Text;
            String password = passwordBox.Password;
            String cpassword = cPasswordBox.Password;
            String email = emailTextBox.Text;

            if (username.Length == 0 || password.Length == 0 || cpassword.Length == 0
                || email.Length == 0)
            {
                MessageBox.Show("Please fill out all the fields");
                return;
            }

            if (!password.Equals(cpassword))
            {
                MessageBox.Show("Both passwords don't match");
                return;
            }

            if (!isValidEmail(email))
            {
                MessageBox.Show("The email address is invalid");
                return;
            }

            if (DBHelper.userExists(username))
            {
                MessageBox.Show("This username is already taken");
                return;
            }

            if (DBHelper.insertUser(username, password, email))
            {
                MessageBox.Show("Registration was successful");

                MainWindow mainWindow = new MainWindow();

                mainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("An error occured during registration");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WelcomeQuiz welcome = new WelcomeQuiz();
            this.Hide();
            welcome.Show();
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
