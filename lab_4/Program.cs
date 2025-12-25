namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] FirstNames =
            {
                "Никита",
                "Самир",
                "Данил",
                "Кирилл",
                "Анна",
                "Петр",
                "Динара",
                "Алина",
                "Андрей",
                "Артем",
                "Роман",
                "Матвей",
                "Анастасия",
                "Альбина",
                "Юрий",
                "Артем",
                "Георгий",
                "Рустам",
                "Андрей",
                "Егор",
                "Андрей",
                "Данил",
                "Антон"
            };

            string[] SecondNames =
            {
                "Алексеев",
                "Ахмедеев",
                "Бондин",
                "Вольнов",
                "Гергерт",
                "Гончаров",
                "Жакина",
                "Зданникова",
                "Зимин",
                "Кабулов",
                "Клексин",
                "Лазарев",
                "Назарова",
                "Наурзбаева",
                "Поварнин",
                "Решетов",
                "Сарсембаев",
                "Тастемиров",
                "Тимошин",
                "Трукан",
                "Фельдт",
                "Чугунов",
                "Шмидт"
            };

            string[] new_string = new string[2 * FirstNames.Length];
            int j = 0;
            for (int i = 0; i < FirstNames.Length; i++)
            {
                    new_string[i * 2] = FirstNames[i];
                    new_string[i * 2 + 1] = SecondNames[i];
            }
            foreach (string name in new_string)
            {
                Console.WriteLine(name);
            }
        }
    }
}
