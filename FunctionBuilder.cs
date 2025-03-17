namespace SteveSharp;

public static class FunctionBuilder {
    public static List<string> Commands { get; set; } = new List<string> {};

    public static void Add(string command) {
        Commands.Add(command);
    }

    public static string[] Collect() {
        return Commands.ToArray<string>();
    }

    public static void Clear() {
        Commands.Clear();
    }
}