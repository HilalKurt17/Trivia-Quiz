namespace TriviaQuiz
{
    public partial class results : Form
    {
        // inform user about wrong and correct answers
        public results(int correct_answers, int wrong_answers)
        {
            InitializeComponent();
            number_of_correct_answers.Text = correct_answers.ToString();
            number_of_wrong_answers.Text = wrong_answers.ToString();
        }


        private void bttn_close_Click(object sender, EventArgs e)
        {
            while (Application.OpenForms.Count > 0)
            {
                Application.OpenForms[0].Close();
            }

        }
    }
}
