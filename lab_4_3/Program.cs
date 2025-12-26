namespace lab_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Student> KickFromUniversity = new Queue<Student>();

            for(int i = 0; i < 10; i++ )
            {
                Student student = Student.GenerateStudent();
                Console.WriteLine($"            Студент №{i + 1}");
                Console.WriteLine(student.GetStudentInfo());

                if (student.GetDecision())
                {
                    KickFromUniversity.Enqueue(student);
                    Console.WriteLine($"Добавлен в очередь: {student.SecondName}");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nСписок отчисленных:");

            while (KickFromUniversity.Count > 0)
            {
                Console.WriteLine(KickFromUniversity.Dequeue().SecondName);
            }
           

            //foreach (Student student in KickFromUniversity)
            //{
            //    Console.WriteLine(student.SecondName);
                
            //}
        }
    }
}