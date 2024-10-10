namespace Quiz_Game
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> questions = GetQandA();
            string answer;
            int score = 0;
            int numberOfQuestions = questions.Count;

            Console.WriteLine("----------------------------------------\nAnswer true or false for the following questions\n-----------------------------------------");

            foreach(var question in questions.Keys)
            {
                Console.WriteLine("\n" + question);
                
                answer = GetValidatedAnswer();

                if (answer == questions.GetValueOrDefault(question))
                {
                    score++;
                }

                questions.Remove(question);
            }

            Console.WriteLine($"You scored {score} out of {numberOfQuestions}");
        }

        public static string GetValidatedAnswer()
        {
            string answer = Console.ReadLine().ToLower();

            while (answer != "true" && answer != "false")
            {
                Console.WriteLine("\nEnter the correct value\n");
                answer = Console.ReadLine().ToLower();
            }

            return answer;
        }
        public static Dictionary<string, string> GetQandA()
        {
            Dictionary<string, string> QandA = new Dictionary<string, string>();

            QandA.Add("C# is a statically typed language.", "true");
            QandA.Add("C# supports multiple inheritance.", "false");
            QandA.Add("C# is platform-independent.", "true");
            QandA.Add("C# is case-sensitive.", "true");

            return QandA;
        }
    }
}
