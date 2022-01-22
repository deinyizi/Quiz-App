using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Quiz.Model;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for QuizPage.xaml
    /// </summary>
    public partial class QuizPage : Window
    {
        List<Question> questions;
        List<String> answers;
        public QuizPage()
        {
            InitializeComponent();
        }

        int questionIndex = 0;
        int questionCount = 0;
        int timeRemaining = 300; // all tests will last 10 minutes = 600 seconds
        User currentUser;

        public void setPrevButton(int index)
        {
            if (index == 0)
            {
                prevButton.IsEnabled = false;
                prevButton.Background = Brushes.Black;
            }
            else
            {
                prevButton.IsEnabled = true;
                prevButton.Background = Brushes.Red;
            }
        }
        public void setNextButton(int index)
        {
            if (index == questionCount - 1)
            {
                nextButton.IsEnabled = false;
                nextButton.Background = Brushes.Black;
            }
            else
            {
                nextButton.IsEnabled = true;
                nextButton.Background = Brushes.Red;
            }
        }

        public void setQuestion(int index)
        {
            questionTextBox.Text = questions[index].QuestionStr;
            option1.Text = questions[index].Option1;
            option2.Text = questions[index].Option2;
            option3.Text = questions[index].Option3;
            option4.Text = questions[index].Option4;
        }
        
        public void setCurrentQuestion(int index)
        {
            questionIndexTextBox.Text = "Question " + ((index + 1) + "") + " of " + (questionCount + "");
        }

        public void shuffle()
        {
            int length = questions.Count;
            while (length > 0)
            {
                length--;
                Random r = new Random();
                int k = r.Next(length + 1);
                Question t = questions[k];
                questions[k] = questions[length];
                questions[length] = t;
            }
        }

        public QuizPage(List<Question> questions, User currentUser)
        {
            InitializeComponent();

            this.currentUser = currentUser;

            this.questions = questions;
            shuffle();
            if (questions.Count == 0)
            {
                MessageBox.Show("There are no questions for this subject");
                SubjectPick subjectPick = new SubjectPick();
                this.Hide();
                subjectPick.Show();
            }
            
            setQuestion(questionIndex);
            
            questionCount = questions.Count;
            
            answers = new List<String>();
            for (int i = 0; i < questionCount; i++)
            {
                string cur = "";
                answers.Add(cur);
            }
            
            setCurrentQuestion(questionIndex);
            
            setPrevButton(questionIndex);
            setNextButton(questionIndex);
            
            submitButton.Background = Brushes.Red;
            cancelButton.Background = Brushes.Red;

            setTimerValue();

            DispatcherTimer testTimer = new DispatcherTimer();
            testTimer.Tick += testTimer_Tick;
            testTimer.Interval = new TimeSpan(0, 0, 1);
            testTimer.Start();
        }

        public void setTimerValue()
        {
            int minute = timeRemaining / 60;
            int second = timeRemaining % 60;
            String minuteStr = (minute < 5 ? "0" + (minute + "") : (minute + ""));
            String secondStr = (second < 5 ? "0" + (second + "") : (second + ""));
            timerTextBox.Text = "TIME: " + minuteStr + ":" + secondStr;
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            --timeRemaining;
            if (timeRemaining == 0)
            {
                setCurrentAnswer();
                submit();
            } 
            else
            {
                setTimerValue();
            }
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        public void setCurrentAnswer()
        {
            if (radioButton1.IsChecked == true)
            {
                answers[questionIndex] = option1.Text;
            }
            else if (radioButton2.IsChecked == true)
            {
                answers[questionIndex] = option2.Text;
            }
            else if (radioButton3.IsChecked == true)
            {
                answers[questionIndex] = option3.Text;
            }
            else if (radioButton4.IsChecked == true)
            {
                answers[questionIndex] = option4.Text;
            }
        }

        public void clearAnswer()
        {
            radioButton1.IsChecked = false;
            radioButton2.IsChecked = false;
            radioButton3.IsChecked = false;
            radioButton4.IsChecked = false;
        }

        public void setNewAnswer()
        {
            if (!answers[questionIndex].Equals(""))
            {
                if (answers[questionIndex] == option1.Text)
                {
                    radioButton1.IsChecked = true;
                }
                if (answers[questionIndex] == option2.Text)
                { 
                    radioButton2.IsChecked = true;
                }
                if (answers[questionIndex] == option3.Text)
                {
                    radioButton3.IsChecked = true;
                }
                if (answers[questionIndex] == option4.Text)
                {
                    radioButton4.IsChecked = true;
                }
            }
        }

        private void prevButton_Click(object sender, RoutedEventArgs e)
        {
            setCurrentAnswer();
            clearAnswer();
            --questionIndex;
            setNewAnswer();
            setQuestion(questionIndex);
            setCurrentQuestion(questionIndex);
            setPrevButton(questionIndex);
            setNextButton(questionIndex);
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            setCurrentAnswer();
            clearAnswer();
            ++questionIndex;
            setNewAnswer();
            setQuestion(questionIndex);
            setCurrentQuestion(questionIndex);
            setPrevButton(questionIndex);
            setNextButton(questionIndex);
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                SubjectPick subjectPick = new SubjectPick(currentUser);
                this.Hide();
                subjectPick.Show();
            } 
            else
            {
                return;
            }
        }

        public void submit()
        {
            int score = 0;
            for (int i = 0; i < questionCount; i++)
            {
                if (answers[i] == questions[i].Answer)
                {
                    ++score;
                }
            }
            SuccessQuizPage success = new SuccessQuizPage(score, questionCount, currentUser);
            this.Hide();
            success.Show();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            setCurrentAnswer();
            if (MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                submit();
            }
            else
            {
                return;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
