using Cybersecurity_Chatbot_GUI.Properties;
using CyberSecurityBotGUI;
using System;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Shapes;

public class SoundManager
{
    public static void PlayGreeting()
    {
      try
        {
            SoundPlayer player = new SoundPlayer(Resources. WhatsApp_Audio_2026_06_24_at_05_32_07);
            player.Play();
        }
        catch
        {
            MessageBox.Show("Error playing audio.");
        }
    }
}
