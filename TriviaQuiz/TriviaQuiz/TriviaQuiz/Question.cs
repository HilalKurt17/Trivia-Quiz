namespace TriviaQuiz
{
    public class Question
    {
        public string question { get; set; }

        public List<string> options { get; set; }
        public string correct_option { get; set; }

        public Question()
        {
            options = new List<string>();
        }


    }
}
