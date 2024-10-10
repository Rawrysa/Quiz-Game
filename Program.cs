namespace Quiz_Game
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> questions = GetQandA();
            string question, answer;
            int score = 0;
            int numberOfQuestions = questions.Count;

            Console.WriteLine("----------------------------------------\nAnswer true or false for the following questions\n-----------------------------------------");

            while (questions.Count > 0) 
            {
                question = questions.Keys.ElementAt(new Random().Next(0, questions.Count));
                Console.WriteLine("\n" + question);

                bool isvalid = false;

                do
                {
                    answer = Console.ReadLine().ToLower();

                    if (answer == "true" || answer == "false")
                    {
                        isvalid = true;
                        if (answer == questions.GetValueOrDefault(question))
                        {
                            score++;
                        }

                        questions.Remove(question);
                    }
                    else
                    {
                        Console.WriteLine("\nEnter the correct value\n");
                    }
                }
                while (!isvalid);

            }

            Console.WriteLine($"You scored {score} out of {numberOfQuestions}");
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
