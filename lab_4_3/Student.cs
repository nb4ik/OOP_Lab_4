using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_3
{
    interface IStudent
    {
        string GetStudentInfo();
        bool GetDecision();
    }
    public class Student : IStudent
    {
        private string[] FirstNames =
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

        private string[] SecondNames =
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

        private string[] ThirdNames =
        {
                "Алексеевич",
                "Дауленович",
                "Алексеевич",
                "Васильевич",
                "Владимировна",
                "Валентинович",
                "Ханатовна",
                "Алексеевна",
                "Сергеевич",
                "Жамбылович",
                "Сергеевич",
                "Матвеевич",
                "Александровна",
                "Хаербековна",
                "Андреевич",
                "Артемович",
                "Валерьевич",
                "Асхатович",
                "Владимирович",
                "Викторович",
                "Дмитриевич",
                "Александрович",
                "Владисловович"
            };

        private static Random rnd = new Random();

        public string FirstName { get;  set; }
        public string SecondName { get;  set; }
        public string ThirdName { get;  set; }

        public int GradeProgramming { get;  set; }
        public int GradePhilosophy { get;  set; }
        public int GradeWebs { get;  set; }
        public int GradeOptimizationMethods { get;  set; }

        public static Student GenerateStudent()
        {
            Student student = new Student();

            student.FirstName = student.FirstNames[rnd.Next(0, student.FirstNames.Length)];
            student.SecondName = student.SecondNames[rnd.Next(0, student.SecondNames.Length)];
            student.ThirdName = student.ThirdNames[rnd.Next(0, student.ThirdNames.Length)];

            student.GradeProgramming = rnd.Next(2, 6);
            student.GradePhilosophy = rnd.Next(2, 6);
            student.GradeWebs = rnd.Next(2, 6);
            student.GradeOptimizationMethods = rnd.Next(2, 6);
            return student;
        }

        public bool GetDecision()
        {
            int[] grades = { GradeProgramming, GradePhilosophy, GradeWebs, GradeOptimizationMethods };
            double average = (GradeOptimizationMethods + GradePhilosophy + GradeWebs + GradeProgramming) / 4.0;

            int countOfThrees = 0;

            foreach (int grade in grades)
            {
                if (grade == 2) return true;
                if (grade == 3) countOfThrees++;
            }

            if (average < 3.3) return true;
            if (countOfThrees > 2) return true;
            return false;
        }
        public string GetStudentInfo()
        {
            Console.WriteLine(new string('=', 40));
            string res = "";
            res += $"Фио: {SecondName} {FirstName} {ThirdName}\n";
            res += "     Оценки по предметам    \n";
            res += $"Программирование: {GradeProgramming}\n";
            res += $"Философия: {GradePhilosophy}\n";
            res += $"Методы оптимизации: {GradeOptimizationMethods}\n";
            res += $"Вывод: {(GetDecision() ? "Студент отчислен" : "Студент не отчислен")}\n";
            return res;
        }

    }
}