namespace lab_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Think> badThink = new Stack<Think>();

            Think thought1 = new Think(TypeThink.Study);
            Think thought2 = new Think(TypeThink.Games);
            Think thought3 = new Think(TypeThink.Food);

            Console.WriteLine($"Первая мысль: {thought1.Content}");
            Console.WriteLine(thought1.GetThinkInfo());
            Console.WriteLine($"Вторая мысль: {thought2.Content}");
            Console.WriteLine(thought2.GetThinkInfo());
            Console.WriteLine($"Третья мысль: {thought3.Content}");
            Console.WriteLine(thought3.GetThinkInfo());

            for (int i = 0; i < 3; i++)
            {
                Think think = new Think(TypeThink.Games);
            }
        }
    }
}
