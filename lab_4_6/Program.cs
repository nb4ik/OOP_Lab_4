namespace lab_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Array =
           {
                "Алексеев",
                "Никита",
                "Ахмедеев",
                "Самир",
                "Бондин",
                "Данил",
                "Вольнов",
                "Кирилл",
                "Гергерт",
                "Анна",
                "Гончаров",
                "Петр",
                "Жакина",
                "Динара",
                "Зданникова",
                "Алина",
                "Зимин",
                "Андрей",
               "Кабулов",
                "Артем",
                "Клексин",
                "Роман",
                "Лазарев",
                "Матвей",
                "Назарова",
                "Анастасия",
                "Наурзбаева",
                "Альбина",
                "Поварнин",
                "Юрий",
                "Решетов",
                "Артем",
                "Сарсембаев",
                "Георгий",
                "Тастемиров",
                "Рустам",
                "Тимошин",
                "Андрей",
                "Трукан",
                "Егор",
                "Фельдт",
                "Андрей",
                "Чугунов",
                "Данил",
                "Шмидт",
                "Антон"
            };

            string[] FirstNames = new string[Array.Length / 2];
            string[] SecondNames = new string[Array.Length / 2];

            for (int i = 0; i < Array.Length / 2; i++)
            {
                FirstNames[i] = Array[i * 2 + 1];
                SecondNames[i] = Array[i * 2];
            }

            Console.WriteLine("Имена:");
            foreach(string name in FirstNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\nФамилии:");
            foreach (string name in SecondNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
