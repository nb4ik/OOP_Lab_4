using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_10
{
    public enum TypeThink
    {
        Food = 1,
        Games = 2,
        Study = 3
    }
    public class Think
    {
        private static Random rnd = new Random();

        private static Dictionary<TypeThink, string[]> thoughtTemplates = new Dictionary<TypeThink, string[]>
    {
        {
            TypeThink.Study, new string[]
            {
                "Нужно подготовиться к экзамену",
                "Пора сделать домашнее задание",
                "Может не идти на лекцию?",
                "Может, почитать что-то полезное?",
                "Физика это хорошо"
            }
        },
        {
            TypeThink.Food, new string[]
            {
                "Нужно правильно питаться",
                "Хочу что то сладкое",
                "Пора приготовить ужин",
                "Может, заказать пиццу?",
                "Салат Цезарь"
            }
        },
        {
            TypeThink.Games, new string[]
            {
                "Хочу перепройти cyberpunk",
                "Может поиграть в доту?...",
                "Нужен ли гринд?",
                "Пора сделать перерыв",
                "Пора пройти Isaac"
            }
        }
    };
        private string GenerateRandomThink(TypeThink type)
        {
            var templates = thoughtTemplates[type];
            int index = rnd.Next(0, 4);
            return templates[index];
        }
        public TypeThink Type { get; set; }
        public string Content { get; set; }
        public Think(TypeThink type)
        {
            Type = type;
            Content = GenerateRandomThink(type);
        }

        public bool GetDecision()
        {
            switch (Type)
            {
                case TypeThink.Games:
                    string[] badGamesWords =
                    {
                        "доту", "перерыв", "гринд"
                    };
                    foreach (string key in badGamesWords)
                    {
                        if (Content.Contains(key)) return true;
                    }
                    return false;

                case TypeThink.Study:
                    string[] badStudyWords =
                    {
                        "подготовиться", "домашнее задание", "почитать"
                    };
                    foreach (string key in badStudyWords)
                    {
                        if (Content.Contains(key)) return true;
                    }
                    return false;

                case TypeThink.Food:
                    string[] badFoodWords =
                    {
                        "правильно", "приготовить"
                    };
                    foreach (string key in badFoodWords)
                    {
                        if (Content.Contains(key)) return true;
                    }
                    return false;

                default:
                    return false;
            }
        }
    }
}
