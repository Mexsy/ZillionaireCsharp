using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillionaire
{
    class Questions
    {
        private int answer;
        private String option1;
        private String option2;
        private String option3;
        private String option4;
        private String question;

        public Questions(String ques,String one, String two, String three, String four, int ans)
        {
            this.question = ques;
            this.option1 = one;
            this.option2 = two;
            this.option3 = three;
            this.option4 = four;
            this.answer = ans;
            Console.WriteLine("Question has been set");
        }

        public String getQuestion()
        {
            return question;
        }

        public String getOption1()
        {
            return option1;
        }

        public String getOption2()
        {
            return option2;
        }

        public String getOption3()
        {
            return option3;
        }

        public String getOption4()
        {
            return option4;
        }

        public int getAnswer() {
            return answer;
        }

        public bool checkAnswer(int a)
        {
            if (a == answer) { return true; }

            else
            {
                return false;
            }

        }
    }
}
