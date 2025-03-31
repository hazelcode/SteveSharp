using SteveSharp.Generic;
using SteveSharp.JsonShapes;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core;

public static class Title {
#region /title actionbar
    public static void Actionbar(EntityTarget targets, TextComponent text) => FunctionBuilder.Add(Str.Title.Actionbar(targets, text));
    public static void Actionbar(EntityTarget targets, TextComponent[] text) => FunctionBuilder.Add(Str.Title.Actionbar(targets, text));
    public static void Actionbar(string targets, TextComponent text) => FunctionBuilder.Add(Str.Title.Actionbar(targets, text));
    public static void Actionbar(string targets, TextComponent[] text) => FunctionBuilder.Add(Str.Title.Actionbar(targets, text));
#endregion
#region /title title
    public static void ShowTitle(EntityTarget targets, TextComponent text) => FunctionBuilder.Add(Str.Title.ShowTitle(targets, text));
    public static void ShowTitle(EntityTarget targets, TextComponent[] text) => FunctionBuilder.Add(Str.Title.ShowTitle(targets, text));
    public static void ShowTitle(string targets, TextComponent text) => FunctionBuilder.Add(Str.Title.ShowTitle(targets, text));
    public static void ShowTitle(string targets, TextComponent[] text) => FunctionBuilder.Add(Str.Title.ShowTitle(targets, text));
#endregion
#region /title subtitle
    public static void Subtitle(EntityTarget targets, TextComponent text) => FunctionBuilder.Add(Str.Title.Subtitle(targets, text));
    public static void Subtitle(EntityTarget targets, TextComponent[] text) => FunctionBuilder.Add(Str.Title.Subtitle(targets, text));
    public static void Subtitle(string targets, TextComponent text) => FunctionBuilder.Add(Str.Title.Subtitle(targets, text));
    public static void Subtitle(string targets, TextComponent[] text) => FunctionBuilder.Add(Str.Title.Subtitle(targets, text));
#endregion
#region /title clear
    public static void Clear(EntityTarget target) => FunctionBuilder.Add(Str.Title.Clear(target));
    public static void Clear(string target) => FunctionBuilder.Add(Str.Title.Clear(target));
#endregion
#region /title reset
    public static void Reset(EntityTarget targets) => FunctionBuilder.Add(Str.Title.Reset(targets));
    public static void Reset(string targets) => FunctionBuilder.Add(Str.Title.Reset(targets));
#endregion
#region /title times
    public static void Times(EntityTarget targets, string fadeIn, string stay, string fadeOut) => FunctionBuilder.Add(Str.Title.Times(targets, fadeIn, stay, fadeOut));
    public static void Times(string targets, string fadeIn, string stay, string fadeOut) => FunctionBuilder.Add(Str.Title.Times(targets, fadeIn, stay, fadeOut));
#endregion
}