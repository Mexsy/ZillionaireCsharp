using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zillionaire
{
    class GeneralKnowledge
    {
        private List<Questions> general_questions = new List<Questions>();
        private List<Questions> hard_general_questions = new List<Questions>();

        public GeneralKnowledge() {
            Questions q1 = new Questions("How many days are in a year?", "300", "366", "365", "266", 3);
            general_questions.Add(q1);
            Questions q2 = new Questions("What is the last name of Big Bang's Sheldon?", "Cooper", "Whooper", "Super", "Mosby", 1);
            general_questions.Add(q2);
            Questions q3 = new Questions("Which of these movies tops the box office earnings?", "Skyfall", "Titanic", "Toy Story 3", "Avatar", 4);
            general_questions.Add(q3);
            Questions q4 = new Questions("What year did world war 2 end?", "1999", "1939", "1945", "2013", 3);
            general_questions.Add(q4);
            Questions q5 = new Questions("Where is Nigeria located?", "West Africa", "South America", "Asia", "East Africa", 1);
            general_questions.Add(q5);
            Questions q6 = new Questions("What is the capital of the U.S?", "New York", "Florida", "Washington D.C", "California", 3);
            general_questions.Add(q6);
            Questions q7 = new Questions("What is the shape of the earth?", "Round", "Spherical", "Orbital", "Rectangular", 2);
            general_questions.Add(q7);
            Questions q8 = new Questions("What is the largest mammal on earth?", "A Lion", "An Elephant", "A Blue Whale", "A Horse", 3);
            general_questions.Add(q8);
            Questions q9 = new Questions("Grand Central Terminal, Park Avenue, New York is the world's?", "largest railway station", "highest railway station", "longest railway station", "none of these", 1);
            hard_general_questions.Add(q9);
            Questions q10 = new Questions("For which of the following disciplines is Nobel Prize awarded?", "Physics and Chemistry", "Physiology or Medicine", "Literature, Peace and Economics", "All of these", 4);
            hard_general_questions.Add(q10);
            Questions q11 = new Questions("Galileo was an Italian astronomer who?", "developed the telescope", "discovered four satellites of Jupiter", "discovered a pendulum produces a regular time", "All of the above", 4);
            general_questions.Add(q11);
            Questions q12 = new Questions("Exposure to sunlight helps a person improve his health because?", "the infrared light kills bacteria in the body", "resistance power increases", "the pigment cells in the skin get stimulated and produce a healthy tan", "the ultraviolet rays convert skin oil into Vitamin D", 4);
            general_questions.Add(q12);
            Questions q13 = new Questions("Golf player Vijay Singh belongs to which country?", "USA", "Fiji", "India", "UK", 2);
            hard_general_questions.Add(q13);
            Questions q14 = new Questions("First China War was fought between?", "China and Britain", "China and France", "China and Egypt", "China and Greece", 1);
            hard_general_questions.Add(q14);
            Questions q15 = new Questions("Headquarters of UNO are situated at?", "New York, USA", "Haque (Netherlands)", "Geneva", "Paris", 1);
            general_questions.Add(q15);
        }

        public Questions get_genQuestion()
        {
            //new instance of random class
            Random rand = new Random();
            //generate a random number between 0 and the size of the question ArrayList
            int questNo = rand.Next(general_questions.Count);
            //return the question at the generated random number.
            Questions store_question = general_questions[questNo];
            //store the returned question
            general_questions.RemoveAt(questNo);
            //remove question from arraylist
            return store_question;
            //return the stored question
        }

        public Questions get_hard_genQuestion()
        {
            //new instance of random class
            Random rand = new Random();
            //generate a random number between 0 and the size of the question ArrayList
            int questNo = rand.Next(hard_general_questions.Count);
            //return the question at the generated random number.
            Questions store_question = hard_general_questions[questNo];
            //store the returned question
            hard_general_questions.RemoveAt(questNo);
            //remove question from arraylist
            return store_question;
            //return the stored question
        }
    }
}
