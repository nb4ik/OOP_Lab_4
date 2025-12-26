using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_10
{
    interface IThink
    {
        string GetThinkInfo();
        bool GetDecision();
    }
    public enum TypeThink
    {
        Food = 1,
        Games = 2,
        Study = 3
    }
    public class Think : IThink
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
            }
        },
        {
            TypeThink.Food, new string[]
            {
                "Нужно правильно питаться",
                "Хочу что то сладкое",
                "Пора приготовить ужин",
                "Может, заказать пиццу?",
            }
        },
        {
            TypeThink.Games, new string[]
            {
                "Хочу перепройти cyberpunk",
                "Может поиграть в доту?...",
                "Нужен ли гринд?",
                "Пора сделать перерыв",
            }
        }
    };
        public static Think GenerateThink()
        {
            Array values = Enum.GetValues(typeof(TypeThink));
            TypeThink randomType = (TypeThink)values.GetValue(rnd.Next(values.Length));

            string[] templates = thoughtTemplates[randomType];
            int index = rnd.Next(templates.Length);
            string content = templates[index];

            Think think = new Think();
            think.Type = randomType;
            think.Content = content;

            return think;
        }
        public TypeThink Type { get; set; }
        public string Content { get; set; }

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

        public string GetThinkInfo()
        {
            return GetDecision() ? "Плохая мысль" : "хорошая мысль";
        }
    }
}
