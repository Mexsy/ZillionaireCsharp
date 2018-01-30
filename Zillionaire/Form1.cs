using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zillionaire
{
    public partial class Form1 : Form
    {
        private int FREEPASS = 0;// allows user skip current question.
        private static int REFRESH_LIFE_LINES = 1;// all life lines are made available again, EXCEPT CHANCE.
        private static int NEW_QUESTION = 2;// player gets a new question.
        private static int PARDON = 3;// player's next wrong anwer will be pardon and removed but player will still need to answer the question.
        private static int OUCH = 4;// player loses all points before previous guaranteed checkpoint.
        private String player_name;
        private Science scienceQuest;
        private int correct_answer;
        private int number_of_questions_answered;
        private static int checkPoint1, checkPoint2, checkPoint3;
        private bool pardon = false;

        public Form1(string text)
        {
            InitializeComponent();
            player_name = text.Trim();
            scienceQuest = new Science();
            getscienceQuestion();
            number_of_questions_answered = 0;
            checkPoint1 = 1;
            checkPoint2 = 6;
            checkPoint3 = 11;
            //List<String> score_list = new List<string>();
            listBoxScore.Items.Add(0);
            listBoxScore.Items.Add(500);
            listBoxScore.Items.Add(1000);
            listBoxScore.Items.Add(2000);
            listBoxScore.Items.Add(5000);
            listBoxScore.Items.Add(10000);
            //listBoxScore.Items.Add(20000);
            listBoxScore.Items.Add(50000);
            listBoxScore.Items.Add(75000);
            listBoxScore.Items.Add(150000);
            listBoxScore.Items.Add(250000);
            listBoxScore.Items.Add(500000);
            listBoxScore.Items.Add(1000000);
            SetScore();
            //listBoxScore.Items.Add(score_list);
        }

        // This method gets the science questions from the Science class arrayList scienceQuestions
        // which is of type Question, which takes parameters (String, String, String, String, int)
        // Then it sets the values in the textfield.
        private void getscienceQuestion()
        {
            Questions quest = scienceQuest.get_sciQuestion();
            questionTextBox.Text = quest.getQuestion();
            option1.Text = quest.getOption1();
            option2.Text = quest.getOption2();
            option3.Text = quest.getOption3();
            option4.Text = quest.getOption4();
            correct_answer = quest.getAnswer();
        }

        // Gets hard science questions when the user get to check point 2.
        private void gethardscienceQuestion()
        {
            Questions quest = scienceQuest.get_hard_sciQuestion();
            questionTextBox.Text = quest.getQuestion();
            option1.Text = quest.getOption1();
            option2.Text = quest.getOption2();
            option3.Text = quest.getOption3();
            option4.Text = quest.getOption4();
            correct_answer = quest.getAnswer();
        }


        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void questionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void option1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (correct_answer == 1)
            {
                showMessage();
                SetQuest();
                number_of_questions_answered++;
                this.timer1.Start();
                SetScore();
            }
            else if (pardon) {
                pardon = false;
                Pardon(1);
            }
            else
            {
                ShowMyFailedDialogBox();
            }


        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (correct_answer == 2)
            {
                showMessage();
                SetQuest();
                number_of_questions_answered++;
                SetScore();
            }
            else if (pardon)
            {
                pardon = false;
                Pardon(2);
            }
            else
            {
                ShowMyFailedDialogBox();
            }
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            if (correct_answer == 3)
            {
                showMessage();
                SetQuest();
                number_of_questions_answered++;
                SetScore();
            }

            else if (pardon)
            {
                pardon = false;
                Pardon(3);
            }
            else
            {
                ShowMyFailedDialogBox();
            }
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            if (correct_answer == 4)
            {
                showMessage();
                SetQuest();
                number_of_questions_answered++;
                SetScore();
            }
            else if (pardon)
            {
                pardon = false;
                Pardon(4);
            }
            else
            {
                ShowMyFailedDialogBox();
            }
        }

        private String getCorrectAns() {
            String answer = "";
            switch (correct_answer) {
                case 1:
                    answer = option1.Text.ToString();
                    break;
                case 2:
                    answer = option2.Text.ToString();
                    break;
                case 3:
                    answer = option3.Text.ToString();
                    break;
                case 4:
                    answer = option4.Text.ToString();
                    break;

            }
            return answer;
        }
        
        private void SetQuest() {

            if (number_of_questions_answered >= checkPoint2) {
                gethardscienceQuestion();
            }
            else {
                getscienceQuestion();
            }
        }

        public void SetScore() {
            listBoxScore.SelectedIndex = number_of_questions_answered;
        }

        public void resetScore()
        {
            listBoxScore.SelectedIndex = 0;
        }

        private void showMessage() {
            if (number_of_questions_answered == checkPoint1 || number_of_questions_answered == checkPoint2 || number_of_questions_answered == checkPoint3)
            {
                ShowCheckPoint();
            }
            else
            {
                ShowMyDialogBox();
            }
        }

        public void ShowMyDialogBox()
        {
            MessageBox.Show("You chose the correct answer");
        }

        public void ShowMyFailedDialogBox()
        {
            MessageBoxButtons messageBoxButtons = new MessageBoxButtons();
            string score = listBoxScore.Items[number_of_questions_answered].ToString();
            insertPlayerScore(score);
            if (MessageBox.Show("You are incorrect, the right answer is " + getCorrectAns() + "\n Your final score is: " + listBoxScore.Items[number_of_questions_answered], "Lmfao NOOB, You LOST", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
            {
                resetScore();
                scienceQuest = new Science();
                getscienceQuestion();
            }
            else {
                Dispose();
            }
        }

        public void ShowCheckPoint()
        {
            MessageBox.Show("You have achieved a guaranteed amount of " + listBoxScore.Items[number_of_questions_answered]);
        }

        private int insertPlayerScore(string score) {
            int x = -34;
            if (!string.IsNullOrEmpty(player_name)) {
                //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Emeka\source\repos\Zillionaire\Zillionaire\Database2.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("queryString", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", player_name);
                cmd.Parameters.AddWithValue("@score", score);
                con.Open();
                x = cmd.ExecuteNonQuery();
                con.Close();
            }
            return x;
        }

        private void fifty_fifty_button_click(object sender, EventArgs e)
        {
            fifty_fifty_button.Enabled = false;
            fifty_fifty_button.BackColor = Color.Red;
            fifty_fifty_button.FlatAppearance.BorderSize = 0;
            int first_option;
            int second_option;
            Random rand = new Random();

            switch (correct_answer)
            {
                case 1:
                    first_option = 0;
                    second_option = 0;
                    do
                    {
                        first_option = rand.Next(2,5);
                        second_option = rand.Next(2,5);
                    }
                    while (first_option == second_option);
                    RemoveText(first_option, second_option);
                    break;
                case 2:
                    first_option = 0;
                    second_option = 0;
                    do
                    {
                        first_option = rand.Next(1,5);
                        second_option = rand.Next(1,5);
                    }
                    while (first_option == second_option || second_option == correct_answer || first_option == correct_answer);
                    RemoveText(first_option, second_option);
                    break;
                case 3:
                    //generate a random number between 1 and 3
                    first_option = rand.Next(1,3);
                    second_option = 0;
                    do
                    {
                        second_option = rand.Next(1,5);
                    }
                    while (first_option == second_option || second_option == correct_answer);
                    RemoveText(first_option, second_option);
                    break;
                case 4:
                    //generate a random number between 0 and 4
                    first_option = rand.Next(1,4);
                    second_option = 0;
                    do
                    {
                        second_option = rand.Next(1,4);
                    }
                    while (first_option == second_option);
                    RemoveText(first_option,second_option);
                    break;

            }
            

        }

        private void RemoveText(int x, int y) {
            Console.WriteLine(x + " " + y);
            if (x == 1 || y == 1) {
                option1.Text = "";
            }
            if (x == 2 || y == 2) {
                option2.Text = "";
            }
            if (x == 3 || y == 3) {
                option3.Text = "";
            }
            if (x == 4 || y == 4) {
                option4.Text = "";
            }
        }

        private void Chance_Click(object sender, EventArgs e)
        {
            Chance.Enabled = false;
            Chance.BackColor = Color.Red;
            int chance = getChance();

            if (chance == FREEPASS) {
                if (MessageBox.Show("You just got a free pass to the next question", "CONGRATULATIONS", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    SetQuest();
                    number_of_questions_answered++;
                    SetScore();
                }
            }
            else if (chance == REFRESH_LIFE_LINES)
            {
                fifty_fifty_button.Enabled = true;
                call_button.Enabled = true;
                audience_button.Enabled = true;
            }
            else if(chance == NEW_QUESTION)
            {
                if (MessageBox.Show("Here's a new question to help you out.", "CONGRATULATIONS", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    SetQuest();
                }
            }
            else if(chance == PARDON)
            {
                if (MessageBox.Show("The pardon chip is active for the next question you get wrong", "CONGRATULATIONS", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    pardon = true;
                }
            }
            else if(chance == OUCH)
            {

                if (MessageBox.Show("You were unlucky, all points before previous check point have been removed!", "OUCH", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    if (GetNumeberOfQuestAnswered() > checkPoint1 && GetNumeberOfQuestAnswered() < checkPoint2)
                    {
                        number_of_questions_answered = checkPoint1;
                        SetScore();
                    }
                    else if (GetNumeberOfQuestAnswered() > checkPoint2 && GetNumeberOfQuestAnswered() < checkPoint3)
                    {
                        number_of_questions_answered = checkPoint2;
                        SetScore();
                    }
                }
            }
        }

        private void call_button_Click(object sender, EventArgs e)
        {
            call_button.Enabled = true;
        }

        private void audience_button_Click(object sender, EventArgs e)
        {
            audience_button.Enabled = false;
        }

        public int getChance()
        {
            //new instance of random class
            Random rand = new Random();
            //generate a random number between 0 and 5
            int chance = rand.Next(5);
            //remove question from arraylist
            return chance;
        }

        public void Pardon(int button) {
            switch (button) {
                case 1:
                    option1.Text = "";
                    break;
                case 2:
                    option2.Text = "";
                    break;
                case 3:
                    option3.Text = "";
                    break;
                case 4:
                    option4.Text = "";
                    break;
            }
        }

        private int GetNumeberOfQuestAnswered() {
            return number_of_questions_answered;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }
    }
}
