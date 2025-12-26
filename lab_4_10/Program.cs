namespace lab_4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThinkWrapper badThink = new ThinkWrapper();

            Think thoughtOne = Think.GenerateThink();
            Console.WriteLine(thoughtOne.GetThinkInfo() + "\n");

            Console.WriteLine("Все мысли:");
            for (int i = 0; i < 10; i++)
            {
                Think thought = Think.GenerateThink();
                Console.WriteLine(thought.Content);
                if (thought.GetDecision())
                {
                    badThink.Add(thought.Content);
                }
            }
            if(badThink.Count == 0)
            {
                Console.WriteLine("Плохих мыслей нет");
            }
            else
            {
                Console.WriteLine("\nПлохие мысли:");
                for (int i = 0; i < badThink.Count; i++)
                {
                    Console.WriteLine(badThink[i]);
                }
            }
        }
    }
}
