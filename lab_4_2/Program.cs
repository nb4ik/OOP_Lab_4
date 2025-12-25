namespace lab_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] SecondNames =
            {
               "Зимин",
                "Кабулов",
                "Клексин",
                "Фельдт",
                "Сарсембаев",
                 "Наурзбаева",
                "Поварнин",
                 "Алексеев",
                "Тастемиров",
                "Тимошин",
                "Чугунов",
                "Шмидт",
               "Гергерт",
                "Гончаров",
                "Ахмедеев",
                "Бондин",
                "Вольнов",
               "Решетов",
                "Жакина",
                "Зданникова",
                 "Трукан",
                "Лазарев",
                "Назарова"
            };

            void BubleSort(string[] s)
            {
                int n = s.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (String.Compare(s[j], s[j + 1]) > 0)
                        {
                            string temp = s[j];
                            s[j] = s[j + 1];
                            s[j + 1] = temp;
                        }
                    }
                }
            }

            BubleSort(SecondNames);

            foreach (string res in SecondNames)
            {
                Console.WriteLine(res);
            }
        }
    }
}
