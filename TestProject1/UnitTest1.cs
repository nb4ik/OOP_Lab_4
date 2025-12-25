using lab_4_3;
using NUnit.Framework;
namespace TestProject1
{
    public class Tests
    {
        [TestFixture]
        public class StudentTests
        {
            [Test]
            public void GetDecision_StudentWithGrade2_ShouldReturnTrue()
            {
                var student = new Student
                {
                    FirstName = "Тест",
                    SecondName = "Тестов",
                    ThirdName = "Тестович",
                    GradeProgramming = 5,
                    GradePhilosophy = 4,
                    GradeWebs = 2, // Двойка - должен быть отчислен
                    GradeOptimizationMethods = 3
                };

                var result = student.GetDecision();

                Assert.IsTrue(result, "Студент с оценкой 2 должен быть отчислен");
            }

            [Test]
            public void GetDecision_StudentWithThreeGrade3_ShouldReturnTrue()
            {
                var student = new Student
                {
                    FirstName = "Тест",
                    SecondName = "Тестов",
                    ThirdName = "Тестович",
                    GradeProgramming = 3,
                    GradePhilosophy = 3, // Три тройки
                    GradeWebs = 3,
                    GradeOptimizationMethods = 4
                };

                var result = student.GetDecision();

                Assert.IsTrue(result, "Студент с тремя оценками 3 должен быть отчислен");
            }

            [Test]
            public void GetDecision_StudentWithTwoGrade3_ShouldReturnFalse()
            {
                var student = new Student
                {
                    FirstName = "Тест",
                    SecondName = "Тестов",
                    ThirdName = "Тестович",
                    GradeProgramming = 3,
                    GradePhilosophy = 3, // Две тройки
                    GradeWebs = 4,
                    GradeOptimizationMethods = 5
                };

                var result = student.GetDecision();

                Assert.IsFalse(result, "Студент с двумя оценками 3 не должен быть отчислен (нужно > 2)");
            }

            [Test]
            public void GetDecision_StudentWithLowAverage_ShouldReturnTrue()
            {
                // Arrange
                var student = new Student
                {
                    FirstName = "Тест",
                    SecondName = "Тестов",
                    ThirdName = "Тестович",
                    GradeProgramming = 3,
                    GradePhilosophy = 3,
                    GradeWebs = 3,
                    GradeOptimizationMethods = 4
                    // Средний балл: (3+3+3+4)/4 = 3.25 < 3.3
                };

                var result = student.GetDecision();

                Assert.IsTrue(result, "Студент со средним баллом 3.25 (< 3.3) должен быть отчислен");
            }

            [Test]
            public void GetDecision_GoodStudent_ShouldReturnFalse()
            {
                var student = new Student
                {
                    FirstName = "Тест",
                    SecondName = "Тестов",
                    ThirdName = "Тестович",
                    GradeProgramming = 5,
                    GradePhilosophy = 4,
                    GradeWebs = 4,
                    GradeOptimizationMethods = 5
                    // Средний балл: 4.5 > 3.3, нет двоек, всего одна тройка
                };

                var result = student.GetDecision();

                Assert.IsFalse(result, "Студент с хорошими оценками не должен быть отчислен");
            }
        }
    }
}