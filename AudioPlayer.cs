using System;
using System.IO;
using System.Media;

public class SoundManager
{
    public static void PlayGreeting()
    {
        try
        {
            string path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Assets",
                "greeting.wav");

            if (File.Exists(path))
            {
                SoundPlayer player =
                    new SoundPlayer(path);

                player.Play();
            }
        }
        catch
        {

        }
    }
}