using SteveSharp.Generic;

namespace SteveSharp.Core.Strings;

public static class Recipe {
    public static string Give(Targets targets, string recipe) => $"recipe give {TargetsHandler.Get(targets)} {recipe}";
    public static string Give(string targets, string recipe) => $"recipe give {targets} {recipe}";
    public static string Take(Targets targets, string recipe) => $"recipe take {TargetsHandler.Get(targets)} {recipe}";
    public static string Take(string targets, string recipe) => $"recipe take {targets} {recipe}";
}