namespace lab_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentWrapper studentsToExpel = new StudentWrapper();

            for (int i = 0; i < 10; i++)
            {
                Student student = Student.GenerateStudent();
                Console.WriteLine($"\n            Студент №{i + 1}");
                Console.WriteLine(student.GetStudentInfo());

                if (student.GetDecision())
                {
                    studentsToExpel.Add(student);
                    Console.WriteLine($"\nДобавлен в список на отчисление: {student.SecondName}");
                }
            }

            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine($"Список отчисленных (всего {studentsToExpel.Count} студентов):");

            if (studentsToExpel.Count == 0)
            {
                Console.WriteLine("Нет студентов для отчисления.");
            }
            else
            {
                for (int i = 0; i < studentsToExpel.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {studentsToExpel[i].SecondName} {studentsToExpel[i].FirstName} {studentsToExpel[i].ThirdName}");
                }
            }


        }
    }
}