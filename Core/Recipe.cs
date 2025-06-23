using SteveSharp.Generic;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core;

public static class Recipe {
    public static void Give(Targets targets, string recipe) => FunctionBuilder.Add(Str.Recipe.Give(targets, recipe));
    public static void Give(string targets, string recipe) => FunctionBuilder.Add(Str.Recipe.Give(targets, recipe));
    public static void Take(Targets targets, string recipe) => FunctionBuilder.Add(Str.Recipe.Take(targets, recipe));
    public static void Take(string targets, string recipe) => FunctionBuilder.Add(Str.Recipe.Take(targets, recipe));
}