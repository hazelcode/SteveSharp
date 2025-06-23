namespace SteveSharp;

public static class FunctionBuilder {
    public static List<string> Commands { get; set; } = [];

    public static void Add(string command) {
        Commands.Add(command);
    }

    public static void Add(List<string> commands) {
        Commands = [
            ..Commands,
            ..commands
        ];
    }

    public static string[] Collect() {
        return Commands.ToArray();
    }

    public static void Clear() {
        Commands.Clear();
    }

    public static void BuildFunction(Function function, string id, int packFormat, Project project) {
        // Create context for the function and then, register the contents
        var ctx = new FunctionContext(
            function.Name,
            id,
            FileOrganizer.GetFunctionPath(function.Name),
            packFormat,
            project
        );
        project.FunctionContents.Add(function.Name, function.Body(ctx));
        // Clear stored commands for last function
        Clear();
    }
}