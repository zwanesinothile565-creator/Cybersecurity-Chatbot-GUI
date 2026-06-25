using System.Collections.Generic;
using CyberSecurityBotGUI.Models;

namespace CyberSecurityBotGUI.Services
{
    public class QuizManager
    {
        private int currentQuestion = 0;

        private int score = 0;

        public List<QuizQuestion> Questions =
            new List<QuizQuestion>()
        {
            new QuizQuestion()
            {
                Question =
                "True or False: Password123 is a strong password.",

                CorrectAnswer = "false",

                Explanation =
                "Weak passwords are easy to guess."
            },

            new QuizQuestion()
            {
                Question =
                "True or False: Phishing emails try to steal information.",

                CorrectAnswer = "true",

                Explanation =
                "Phishing attacks steal information."
            }
        };

        public string Question
        {
            get
            {
                if (currentQuestion >= Question.Count)
                {
                    return $"Quiz Complete. Score: {score}/{Question.Count}";
                }
                else
                {
                    return Question[currentQuestion].Question;
                }
            }
        }

        public string CheckAnswer(string answer)
        {
            if (answer.Equals(Questions[currentQuestion]
                .CorrectAnswer, StringComparison.CurrentCultureIgnoreCase))
            {
                score++;
            }

            string result =
                Questions[currentQuestion]
                .Explanation;

            currentQuestion++;

            return result;
        }

        internal void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
