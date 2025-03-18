internal static class Displays
{
    internal static void NewFunction(string path)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("  NEW  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" Created {path} function");
        Console.ResetColor();
    }
    internal static void NewJson(string path)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("  NEW  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" Created {path} JSON file");
        Console.ResetColor();
    }
    internal static void WrittenFunction(string path)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write("  WRT  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($" Written {path} function");
        Console.ResetColor();
    }
    internal static void WrittenJson(string path)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write("  WRT  ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($" Written {path} JSON file");
        Console.ResetColor();
    }
    internal static void SteveSharpDisplay(string name)
    {
        Console.Title = "SteveSharp Log";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n</>   S t e v e S h a r p   L o g   </>\n\nProject: {name}\n\n");
        Console.ResetColor();
    }
    internal static void ProjectCreated()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.Write("   P   ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" Project created succesfully!");
        Console.ResetColor();
    }
}