namespace lab_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> englishRussianDictionary = new Dictionary<string, string>()
            {
                ["book"] = "книга",
                ["house"] = "дом",
                ["hello"] = "привет",
                ["ball"] = "мяч",
                ["car"] = "машина",
                ["bird"] = "птица"
            };

            englishRussianDictionary.Add("computer", "компьютер");
            englishRussianDictionary.Add("programming", "программирование");
            englishRussianDictionary.Add("dictionary", "словарь");

            Console.Write(englishRussianDictionary["book"]);
        }
    }
}
