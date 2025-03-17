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

    public static void BuildFunction(Function function, string id, int packFormat, Project project, ref Dictionary<string, string[]> contentsRepository) {
        // Create context for the function and then, register the contents
        var ctx = new FunctionContext(
            function.Name,
            id,
            FileOrganizer.GetFunctionPath(function.Name),
            packFormat,
            project
        );
        contentsRepository.Add(function.Name, function.Body(ctx));
        // Clear stored commands for last function
        Clear();
    }
}