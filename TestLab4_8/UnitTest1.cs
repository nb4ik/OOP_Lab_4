using lab_4_8;

namespace TestLab4_8
{
    [TestFixture]
    public class ThinkTests
    {
        [Test]
        public void GetDecision_GamesWithBadWord_ReturnsTrue()
        {
            var think = new Think
            {
                Type = TypeThink.Games,
                Content = "Может поиграть в доту?..."
            };

            var result = think.GetDecision();

            Assert.IsTrue(result, "Для TypeThink.Games с содержанием 'доту' должен возвращаться true");
        }

        [Test]
        public void GetDecision_GamesWithoutBadWord_ReturnsFalse()
        {
            var think = new Think
            {
                Type = TypeThink.Games,
                Content = "Хочу перепройти cyberpunk"
            };

            var result = think.GetDecision();

            Assert.IsFalse(result, "Для TypeThink.Games без плохих слов должен возвращаться false");
        }

        [Test]
        public void GetDecision_StudyWithBadWord_ReturnsTrue()
        {
            var think = new Think
            {
                Type = TypeThink.Study,
                Content = "Нужно подготовиться к экзамену"
            };

            var result = think.GetDecision();

            Assert.IsTrue(result, "Для TypeThink.Study с содержанием 'подготовиться' должен возвращаться true");
        }

        [Test]
        public void GetDecision_FoodWithGoodWord_ReturnsFalse()
        {
            var think = new Think
            {
                Type = TypeThink.Food,
                Content = "Может, заказать пиццу?"
            };

            var result = think.GetDecision();

            Assert.IsFalse(result, "Для TypeThink.Food без плохих слов должен возвращаться false");
        }

        [Test]
        public void GetDecision_FoodWithBadWord_ReturnsTrue()
        {
            var think = new Think
            {
                Type = TypeThink.Food,
                Content = "Пора приготовить ужин"
            };

            var result = think.GetDecision();

            Assert.IsTrue(result, "Для TypeThink.Food с содержанием 'приготовить' должен возвращаться true");
        }
    }
}