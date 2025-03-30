using SteveSharp.Generic;

namespace SteveSharp.Core.Strings;

public static class Recipe {
    public static string Give(EntityTarget targets, string recipe) => $"recipe give {EntityTargetHandler.Get(targets)} {recipe}";
    public static string Give(string targets, string recipe) => $"recipe give {targets} {recipe}";
    public static string Take(EntityTarget targets, string recipe) => $"recipe take {EntityTargetHandler.Get(targets)} {recipe}";
    public static string Take(string targets, string recipe) => $"recipe take {targets} {recipe}";
}