namespace Quiz_Game
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> questions = GetQandA();
            string question, answer;


            do
            {
                question = questions.Keys.ElementAt(new Random().Next(0, questions.Count));
                Console.WriteLine(question);

                answer = Console.ReadLine().ToLower();

                if (answer == "true" || answer == "false")
                {
                    Console.WriteLine("\n" + ((answer == questions.GetValueOrDefault(question)) ? "That is correct" : "That is false"));
                    break;
                }
                else
                {
                    Console.WriteLine("The value entered is invalid");
                }

            }
            while (true);
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
