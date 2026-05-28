using System;
using System.Collections.Generic;

namespace CyberSecurityBotGUI
{
    public class Chatbot
    {
        // =========================================
        // VARIABLES
        // =========================================

        private string userName;

        private string userMood = "";

        private string favouriteTopic = "";

        private string currentTopic = "";

        private Random rand = new Random();

        // =========================================
        // DELEGATE
        // =========================================

        public delegate string ResponseHandler(string input);

        ResponseHandler handler;

        // =========================================
        // PASSWORD TIPS
        // =========================================

        List<string> passwordTips = new List<string>()
        {
            "Use strong passwords with letters, numbers, and symbols.",

            "Avoid using personal information in your passwords.",

            "Never reuse passwords across multiple accounts.",

            "Enable two-factor authentication whenever possible.",

            "Use a password manager to store passwords safely."
        };

        // =========================================
        // PHISHING TIPS
        // =========================================

        List<string> phishingTips = new List<string>()
        {
            "Be careful of emails asking for personal information.",

            "Do not click suspicious links from unknown senders.",

            "Always verify the sender before opening attachments.",

            "Scammers often pretend to be trusted companies.",

            "Phishing attacks usually create urgency to trick users."
        };

        // =========================================
        // PRIVACY TIPS
        // =========================================

        List<string> privacyTips = new List<string>()
        {
            "Review your social media privacy settings regularly.",

            "Avoid sharing sensitive information online.",

            "Use strong passwords to protect your accounts.",

            "Limit what personal information you post publicly.",

            "Enable privacy settings on all online accounts."
        };

        // =========================================
        // SAFE BROWSING TIPS
        // =========================================

        List<string> browsingTips = new List<string>()
        {
            "Always check if websites use HTTPS.",

            "Avoid downloading files from unknown websites.",

            "Keep your browser updated for better security.",

            "Use trusted antivirus software.",

            "Avoid entering passwords on suspicious websites."
        };

        // =========================================
        // SCAM TIPS
        // =========================================

        List<string> scamTips = new List<string>()
        {
            "Be cautious of fake giveaways and prize scams.",

            "Never share banking details with strangers online.",

            "Scammers often pressure users to act quickly.",

            "Verify suspicious messages before responding.",

            "Avoid sending money to unknown people online."
        };

        // =========================================
        // CONSTRUCTOR
        // =========================================

        public Chatbot(string name)
        {
            userName = name;

            handler = GetResponse;
        }

        // =========================================
        // STORE USER MOOD
        // =========================================

        public void SetMood(string mood)
        {
            userMood = mood.ToLower();
        }

        // =========================================
        // MAIN RESPONSE METHOD
        // =========================================

        public string GetResponse(string input)
        {
            input = input.ToLower().Trim();

            // =====================================
            // GREETINGS
            // =====================================

            if (input == "hello" ||
                input == "hi" ||
                input == "hey")
            {
                return $"Hello {userName}! How can I help you today?";
            }

            // =====================================
            // PURPOSE
            // =====================================

            if (input.Contains("purpose"))
            {
                return "My purpose is to help users stay safe online and improve cybersecurity awareness.";
            }

            // =====================================
            // HELP
            // =====================================

            if (input.Contains("help"))
            {
                return "You can ask me about passwords, phishing, scams, privacy, malware, VPNs, firewalls, and safe browsing.";
            }

            // =====================================
            // PASSWORD
            // =====================================

            if (input.Contains("password"))
            {
                currentTopic = "password";

                if (input.Contains("curious"))
                {
                    return "I'm glad you're curious about password safety. Strong passwords help protect your accounts from hackers.";
                }

                if (input.Contains("worried"))
                {
                    return "It's understandable to worry about password security. Strong passwords and two-factor authentication improve protection.";
                }

                return "Password safety is an important part of cybersecurity. Strong passwords help protect your online accounts from hackers and cybercriminals.";
            }

            // =====================================
            // PHISHING
            // =====================================

            if (input.Contains("phishing"))
            {
                currentTopic = "phishing";

                // CURIOUS SENTIMENT
                if (input.Contains("curious"))
                {
                    return "Phishing is a cyberattack where scammers pretend to be trusted organisations to steal personal information like passwords or banking details. Cybercriminals often use fake emails, messages, or websites.";
                }

                // WORRIED SENTIMENT
                if (input.Contains("worried"))
                {
                    return "It's understandable to feel worried about phishing because scammers can be very convincing. Phishing is a cyberattack where criminals try to trick users into revealing sensitive information through fake emails or websites. Always verify suspicious links and messages before clicking them.";
                }

                // NORMAL RESPONSE
                return "Phishing is a type of cyberattack where scammers pretend to be trusted organisations or people to steal sensitive information such as passwords, banking details, or personal data. Phishing attacks commonly happen through fake emails, text messages, or websites.";
            }

            // =====================================
            // PRIVACY
            // =====================================

            if (input.Contains("privacy"))
            {
                currentTopic = "privacy";

                favouriteTopic = "privacy";

                if (input.Contains("curious"))
                {
                    return "Privacy helps protect your personal information from cybercriminals and online threats.";
                }

                if (input.Contains("worried"))
                {
                    return "It's normal to worry about online privacy. Reviewing your security settings helps improve protection.";
                }

                return "Privacy in cybersecurity means protecting personal information from unauthorized access or misuse online.";
            }

            // =====================================
            // SAFE BROWSING
            // =====================================

            if (input.Contains("safe browsing") ||
                input.Contains("browsing"))
            {
                currentTopic = "browsing";

                return "Safe browsing means using the internet carefully to avoid dangerous websites, malware, scams, and phishing attacks.";
            }

            // =====================================
            // SCAMS
            // =====================================

            if (input.Contains("scam"))
            {
                currentTopic = "scam";

                if (input.Contains("worried"))
                {
                    return "Scammers can be convincing, but staying alert and verifying information helps protect you.";
                }

                return "Online scams are fraudulent attempts to trick users into giving away money, passwords, or personal information.";
            }

            // =====================================
            // MALWARE
            // =====================================

            if (input.Contains("malware"))
            {
                currentTopic = "malware";

                return "Malware is harmful software designed to damage systems or steal information from devices.";
            }

            // =====================================
            // VPN
            // =====================================

            if (input.Contains("vpn"))
            {
                currentTopic = "vpn";

                return "A VPN encrypts your internet connection and improves online privacy and security.";
            }

            // =====================================
            // FIREWALL
            // =====================================

            if (input.Contains("firewall"))
            {
                currentTopic = "firewall";

                return "A firewall helps block unauthorized access to your computer or network.";
            }

            // =====================================
            // ANTIVIRUS
            // =====================================

            if (input.Contains("antivirus"))
            {
                currentTopic = "antivirus";

                return "Antivirus software detects and removes harmful programs from your device.";
            }

            // =====================================
            // FOLLOW-UP QUESTIONS
            // =====================================

            if (input.Contains("tell me more") ||
                input.Contains("explain more"))
            {
                if (currentTopic == "password")
                {
                    return "Strong passwords should include uppercase letters, lowercase letters, numbers, and symbols.";
                }

                if (currentTopic == "phishing")
                {
                    return "Phishing attacks usually create urgency or fear to manipulate victims. Attackers may pretend to be banks, online stores, or social media companies. Users should avoid clicking suspicious links and always verify the sender.";
                }

                if (currentTopic == "privacy")
                {
                    return "Privacy protection includes limiting personal information shared online and reviewing security settings regularly.";
                }

                if (currentTopic == "browsing")
                {
                    return "Safe browsing includes avoiding unsafe websites and suspicious downloads.";
                }

                if (currentTopic == "scam")
                {
                    return "Online scams often pretend to offer rewards or urgent requests to manipulate users.";
                }

                return "Please ask about a cybersecurity topic first.";
            }

            // =====================================
            // ANOTHER TIP
            // =====================================

            if (input.Contains("another tip") ||
                input.Contains("give me another tip"))
            {
                if (currentTopic == "password")
                {
                    return GetRandomResponse(passwordTips);
                }

                if (currentTopic == "phishing")
                {
                    return GetRandomResponse(phishingTips);
                }

                if (currentTopic == "privacy")
                {
                    return GetRandomResponse(privacyTips);
                }

                if (currentTopic == "browsing")
                {
                    return GetRandomResponse(browsingTips);
                }

                if (currentTopic == "scam")
                {
                    return GetRandomResponse(scamTips);
                }

                return "Please ask about a cybersecurity topic first.";
            }

            // =====================================
            // MEMORY FEATURE
            // =====================================

            if (input.Contains("i like privacy"))
            {
                favouriteTopic = "privacy";

                return "Great! I will remember that you are interested in privacy.";
            }

            if (favouriteTopic == "privacy" &&
                input.Contains("tip"))
            {
                return $"{userName}, since you're interested in privacy, remember to review your account privacy settings regularly.";
            }

            // =====================================
            // SENTIMENT DETECTION
            // =====================================

            if (input.Contains("worried"))
            {
                return "It's understandable to feel worried about cybersecurity threats. Learning online safety practices helps reduce risks.";
            }

            if (input.Contains("frustrated"))
            {
                return "Cybersecurity can feel difficult at times, but you're learning important skills that help keep you safe online.";
            }

            if (input.Contains("curious"))
            {
                return "Curiosity is excellent! Learning cybersecurity helps protect your information online.";
            }

            if (input.Contains("confused"))
            {
                return "That's okay. Cybersecurity can be challenging at first, but I'm here to help explain it clearly.";
            }

            // =====================================
            // THANK YOU
            // =====================================

            if (input.Contains("thank"))
            {
                return "You're welcome! Staying informed is one of the best ways to stay safe online.";
            }

            // =====================================
            // EXIT
            // =====================================

            if (input.Contains("bye") ||
                input.Contains("exit"))
            {
                return "Goodbye! Stay safe online and protect your personal information.";
            }

            // =====================================
            // DEFAULT RESPONSE
            // =====================================

            return "I didn't quite understand that. Could you rephrase your question?";
        }

        // =========================================
        // RANDOM RESPONSE METHOD
        // =========================================

        private string GetRandomResponse(List<string> responses)
        {
            int index = rand.Next(responses.Count);

            return responses[index];
        }
    }
}