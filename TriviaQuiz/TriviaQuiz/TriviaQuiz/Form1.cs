namespace TriviaQuiz
{
    public partial class Form1 : Form
    {



        Random random_question_index = new Random();
        Random random_answer_index = new Random();

        List<int> question_index_list = new List<int>();    // stores index of questions which are shown to the user.
        List<string> shuffled_answers = new List<string>(); // shuffled answer list for each question

        string correct_answer;          // assign correct answer of questions to correct answer
        int correct_answer_counter = 0; // count correct answers
        int wrong_answer_counter = 0;   // count wrong answers
        int second; // timer second



        public Form1()
        {
            InitializeComponent();
            question_select();
        }



        private void question_select()
        {

            int length_questions = VirtualDatabase.quiz_questions.Count();

            if (question_index_list.Count() == 20)
            {
                finish_quiz();
            }



            int index = random_question_index.Next(length_questions);
            string is_it_added = "no";
            //            int is_in_index_list = question_index_list.Find(x => x == index);
            foreach (int i in question_index_list) // check whether the question was shown to the user or not
            {


                if (i == index)          // if the index is added, this means the question is already seen by the user.
                {
                    is_it_added = "yes";
                    break;
                }

            }
            if (is_it_added == "no")     // if it is not shown, show question to the user
            {



                question_index_list.Add(index);   // add index of the question to the shown question list
                // assign question to the question textBox
                txtQuestion.Text = VirtualDatabase.quiz_questions[index].question;
                // store the correct answer
                correct_answer = VirtualDatabase.quiz_questions[index].correct_option;
                // shuffle order of answers of the question
                shuffled_answers = shuffle_answer_list(index);
                // assign shuffled answers to the buttons
                bttnA.Text = "A)    " + shuffled_answers[0];
                bttnA.Tag = shuffled_answers[0];

                bttnB.Text = "B)    " + shuffled_answers[1];
                bttnB.Tag = shuffled_answers[1];

                bttnC.Text = "C)    " + shuffled_answers[2];
                bttnC.Tag = shuffled_answers[2];

                bttnD.Text = "D)    " + shuffled_answers[3];
                bttnD.Tag = shuffled_answers[3];


                timer.Start();
                progressBar1.ForeColor = Color.Violet;
                progressBar1.BackColor = Color.Turquoise;
                progressBar1.Value = 20;


            }

            else
            {
                // if selected question is already seen by the user, select another index 
                question_select();
            }


        }


        private List<string> shuffle_answer_list(int index) // shuffle answers of a question 
        {
            List<string> shuffled_answer_list = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                int random_index = random_answer_index.Next(4); // create random index
                // find value of the random index
                string option = VirtualDatabase.quiz_questions[index].options[random_index];
                // check whether the value is added to the shuffled_answer_list list or not
                string is_it_added = shuffled_answer_list.Find(i => i == option);
                if (is_it_added == null) // if the value is not added, add the value;
                {
                    shuffled_answer_list.Add(option);
                }
                else // if value is added decrease i 
                {
                    i -= 1;
                }

            }

            return shuffled_answer_list;
        }


        private void users_choice(object user_choice)
        {
            if (user_choice != null)
            {
                if ((string)user_choice == correct_answer) // if user answered correctly, increase the counter of correct answers
                {
                    correct_answer_counter++;

                }
                else      // is user answered wrongly, decrease the counter of wrong answers 
                {
                    wrong_answer_counter++;

                }
            }
            else
            {
                wrong_answer_counter++;
            }
            question_select();
        }


        private void button_Click(object sender, EventArgs e)
        {
            timer.Stop();
            // get the clicked button
            Button button_clicked = (Button)sender;

            if (button_clicked != null)
            {
                string user_choice = (string)button_clicked.Tag; // 
                users_choice(user_choice);
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            progressBar1.Value -= 1;
            remain_time.Text = progressBar1.Value.ToString();

            if (progressBar1.Value == 0)
            {
                timer.Stop();
                users_choice(null);
            }


        }

        private void finish_quiz()
        {
            timer.Stop();
            results result = new results(correct_answer_counter, wrong_answer_counter);
            result.ShowDialog();

        }


    }
}