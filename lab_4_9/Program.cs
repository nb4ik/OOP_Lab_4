namespace lab_4_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> russianEnglishDictionary = new Dictionary<string, string>()
            {
                ["книга"] = "book",
                ["дом"] = "house",
                ["привет"] = "hello",
                ["мяч"] = "ball",
                ["машина"] = "car",
                ["птица"] = "bird"
            };

            russianEnglishDictionary.Add("компьютер", "computer");
            russianEnglishDictionary.Add("программирование", "programming");
            russianEnglishDictionary.Add("словарь", "dictionary");

            Console.Write(russianEnglishDictionary["книга"]);
        }
    }
}
