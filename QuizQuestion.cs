namespace CyberSecurityBotGUI.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Explanation { get; internal set; }
    }
}