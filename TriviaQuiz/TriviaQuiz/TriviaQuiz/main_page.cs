namespace TriviaQuiz
{
    public partial class main_page : Form
    {
        Form1 trivia_quiz = new Form1();


        public main_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            trivia_quiz.Show();
            this.Hide();
        }
    }
}
