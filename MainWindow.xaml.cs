using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace CyberSecurityBotGUI
{
    public partial class MainWindow : Window
    {
        private Chatbot bot;

        private string userName = "";

        private bool askedName = false;

        private bool askedMood = false;

        public MainWindow()
        {
            InitializeComponent();

            AddBotMessage("🛡 Welcome to the Cybersecurity Awareness Bot!");
            AddBotMessage("What is your name?");
        }

        // =====================================
        // SEND BUTTON
        // =====================================

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            string input = txtUserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            AddUserMessage(input);

            txtUserInput.Clear();

            // ASK NAME
            if (!askedName)
            {
                userName = input;

                txtUserDisplay.Text = userName;

                bot = new Chatbot(userName);

                askedName = true;

                AddBotMessage($"Nice to meet you, {userName}!");
                AddBotMessage("How are you feeling today?");

                return;
            }

            // ASK MOOD
            if (!askedMood)
            {
                bot.SetMood(input);

                askedMood = true;

                AddBotMessage($"I'm glad you're feeling {input}.");
                AddBotMessage("You can now ask me about cybersecurity topics.");
                AddBotMessage("Examples: password, phishing, privacy, scams");

                return;
            }

            // NORMAL CHATBOT RESPONSE
            string response = bot.GetResponse(input);

            AddBotMessage(response);
        }

        // =====================================
        // PASSWORD BUTTON
        // =====================================

        private void btnPassword_Click(object sender, RoutedEventArgs e)
        {
            AddUserMessage("Tell me about password safety");

            AddBotMessage(bot.GetResponse("password"));
        }

        // =====================================
        // PHISHING BUTTON
        // =====================================

        private void btnPhishing_Click(object sender, RoutedEventArgs e)
        {
            AddUserMessage("Tell me about phishing");

     
        }

        // =====================================
        // PRIVACY BUTTON
        // =====================================

        private void btnPrivacy_Click(object sender, RoutedEventArgs e)
        {
            AddUserMessage("Tell me about privacy");

            AddBotMessage(bot.GetResponse("privacy"));
        }

        // =====================================
        // SAFE BROWSING BUTTON
        // =====================================

        private void btnBrowsing_Click(object sender, RoutedEventArgs e)
        {
            AddUserMessage("Tell me about safe browsing");

            AddBotMessage(bot.GetResponse("safe browsing"));
        }

        // =====================================
        // MALWARE BUTTON
        // =====================================

        private void btnMalware_Click(object sender, RoutedEventArgs e)
        {
            AddUserMessage("Tell me about malware");

            AddBotMessage(bot.GetResponse("malware"));
        }

        // =====================================
        // BOT MESSAGE
        // =====================================

        private void AddBotMessage(string message)
        {
            Paragraph paragraph = new Paragraph();

            Run run = new Run("BOT: " + message);

            run.Foreground = Brushes.LightBlue;

            paragraph.Inlines.Add(run);

            ChatBox.Document.Blocks.Add(paragraph);

            ChatBox.ScrollToEnd();
        }

        // =====================================
        // USER MESSAGE
        // =====================================

        private void AddUserMessage(string message)
        {
            Paragraph paragraph = new Paragraph();

            Run run = new Run("YOU: " + message);

            run.Foreground = Brushes.LightGreen;

            paragraph.Inlines.Add(run);

            ChatBox.Document.Blocks.Add(paragraph);

            ChatBox.ScrollToEnd();
        }
    }
}