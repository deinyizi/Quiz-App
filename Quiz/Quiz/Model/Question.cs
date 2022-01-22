using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Model
{
    public class Question
    {
        private int id;
        private String subject;
        private String questionStr;
        private String option1;
        private String option2;
        private String option3;
        private String option4;
        private String answer;

        public Question(int id, string subject, string questionStr, string option1, string option2, string option3, string option4, string answer)
        {
            this.id = id;
            this.subject = subject;
            this.questionStr = questionStr;
            this.option1 = option1;
            this.option2 = option2;
            this.option3 = option3;
            this.option4 = option4;
            this.answer = answer;
        }

        public int Id { get => id; set => id = value; }
        public string Subject { get => subject; set => subject = value; }
        public string QuestionStr { get => questionStr; set => questionStr = value; }
        public string Option1 { get => option1; set => option1 = value; }
        public string Option2 { get => option2; set => option2 = value; }
        public string Option3 { get => option3; set => option3 = value; }
        public string Option4 { get => option4; set => option4 = value; }
        public string Answer { get => answer; set => answer = value; }
    }
}
