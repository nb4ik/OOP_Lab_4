namespace lab_4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] FirstNames =
            {
                "Егор",
                "Андрей",
                "Данил",
                "Матвей",
                "Андрей",
                "Юрий",
                "Артем",
                "Георгий",
                "Рустам",
                "Алина",
                "Самир",
                "Данил",
                "Кирилл",
                "Анна",
                "Петр",
                "Антон",
                "Андрей",
                "Никита",
                "Артем",
                "Роман",
                "Динара",
                "Анастасия",
                "Альбина"
            };

            void InsertionSort(string[] s)
            {
                for (int i = 0; i < FirstNames.Length; i++)
                {
                    string current = s[i];
                    int j = i - 1;
                    while (j >= 0 && String.Compare(s[j], current) > 0 )
                    {
                        s[j + 1] = FirstNames[j];
                        j--;
                    }
                    s[j + 1] = current;
                }
            }
            
            InsertionSort(FirstNames);

            foreach(string name in FirstNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
