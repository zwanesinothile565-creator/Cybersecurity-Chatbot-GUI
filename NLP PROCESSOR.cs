namespace CyberSecurityBotGUI.Services
{
    public class NLPProcessor
    {
        public string DetectIntent(string input)
        {
            input = input.ToLower();

            if (input.Contains("add task")) return "add_task";
            if (input.Contains("delete task")) return "delete_task";
            if (input.Contains("view tasks")) return "view_tasks";
            if (input.Contains("quiz")) return "quiz";
            if (input.Contains("password")) return "password";
            if (input.Contains("phishing")) return "phishing";
            if (input.Contains("reminder")) return "reminder";

            return "chat";
        }
    }
}