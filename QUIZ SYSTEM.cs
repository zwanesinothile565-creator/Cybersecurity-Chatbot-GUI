using System.Collections.Generic;
using CyberSecurityBotGUI.Models;

namespace CyberSecurityBotGUI.Services
{
    public class QuizManager
    {
        private int index = 0;
        private int score = 0;

        public List<QuizQuestion> Questions = new List<QuizQuestion>()
        {
            new QuizQuestion { Question="Passwords should be reused? (true/false)", CorrectAnswer="false" },
            new QuizQuestion { Question="Phishing tries to steal data? (true/false)", CorrectAnswer="true" },
            new QuizQuestion { Question="VPN increases privacy? (true/false)", CorrectAnswer="true" },
            new QuizQuestion { Question="Malware is safe software? (true/false)", CorrectAnswer="false" },
            new QuizQuestion { Question="HTTPS is secure? (true/false)", CorrectAnswer="true" }
        };

        public string GetQuestion()
        {
            if (index >= Questions.Count)
                return $"Quiz finished! Score: {score}/{Questions.Count}";

            return Questions[index].Question;
        }

        public string Answer(string input)
        {
            if (index < Questions.Count &&
                input.ToLower() == Questions[index].CorrectAnswer)
            {
                score++;
            }

            index++;
            return "Answer recorded.";
        }
    }
}