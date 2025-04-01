namespace SteveSharp.Core.Strings;

public static class Function
{
    public static string Return(int i) => "return " + i;
    public static string Call(string function) => "function " + function;
    public static string Schedule(string function, string time, bool append = false, bool replace = false) {
        if (append && !replace) return $"schedule function {function} {time} append";
        else if (!append && replace) return $"schedule function {function} {time} replace";
        else return $"schedule function {function} {time}";
    }
    public static string ClearSchedule(string function) => $"schedule clear {function}";
}