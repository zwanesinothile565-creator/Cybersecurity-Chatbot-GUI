using System;
using System.Collections.Generic;

namespace CyberSecurityBotGUI.Services
{
    public static class ActivityLogger
    {
        public static List<string> Logs = new List<string>();

        public static void Log(string action)
        {
            Logs.Add($"{DateTime.Now}: {action}");
        }
    }
}