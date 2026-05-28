// ================= UI HELPER =================
public class UIHelper
{
    public static void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;

        Console.WriteLine(@"
       /  \
      /0 0 \    
     /______\   
       ||||
       ||||
      / || \
     /  ||  \
        ||
       /  \
");

        Console.ResetColor();
    }

    public static void DisplayDivider()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("===============================================");
        Console.ResetColor();
    }

    public static void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n========= MENU =========");
        Console.ResetColor();

        Console.WriteLine("1. Password Safety");
        Console.WriteLine("2. Phishing");
        Console.WriteLine("3. Safe Browsing");
        Console.WriteLine("4. Exit");
        Console.WriteLine("========================");
    }

    public static void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }
        Console.WriteLine();
    }
}