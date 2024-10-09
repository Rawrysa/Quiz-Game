namespace Quiz_Game
{
     internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Dictionary<string, string> questions = GetQandA();

            do
            {
                Console.WriteLine(questions
            }
            while (!exit);
        }

        public static Dictionary<string, string> GetQandA()
        {
            Dictionary<string, string> QandA = new Dictionary<string, string>();

            QandA.Add("C# is a statically typed language.", "True");
            QandA.Add("C# supports multiple inheritance.", "False");
            QandA.Add("C# is platform-independent.", "True");
            QandA.Add("C# is case-sensitive.", "True");

            return QandA;
        }
    }
}
