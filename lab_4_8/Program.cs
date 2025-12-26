namespace lab_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> badThink = new Stack<string>();

            Think thoughtOne = Think.GenerateThink();
            Console.WriteLine(thoughtOne.GetThinkInfo() + "\n");

            Console.WriteLine("Все мысли:");
            for (int i = 0; i < 3; i++)
            {
                Think thought = Think.GenerateThink();
                Console.WriteLine(thought.Content);
                if (thought.GetDecision())
                {
                    badThink.Push(thought.Content);
                }
            }
            Console.WriteLine("\nПлохие мысли:");

            while (badThink.Count > 0)
            {
                Console.WriteLine(badThink.Pop());
            }
        }
    }
}
