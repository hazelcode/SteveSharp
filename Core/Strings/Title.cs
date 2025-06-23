using SteveSharp.Generic;
using SteveSharp.JsonShapes;
using System.Text.Json;

namespace SteveSharp.Core.Strings;

public static class Title {
#region /title actionbar
    public static string Actionbar(Targets targets, TextComponent text) {
        return $"title {TargetsHandler.Get(targets)} actionbar {JsonSerializer.Serialize(text)}";
    }
    public static string Actionbar(Targets targets, TextComponent[] text) {
        return $"title {TargetsHandler.Get(targets)} actionbar {JsonSerializer.Serialize(text)}";
    }
    public static string Actionbar(string targets, TextComponent text) {
        return $"title {targets} actionbar {JsonSerializer.Serialize(text)}";
    }
    public static string Actionbar(string targets, TextComponent[] text) {
        return $"title {targets} actionbar {JsonSerializer.Serialize(text)}";
    }
#endregion
#region /title title
    public static string ShowTitle(Targets targets, TextComponent text) {
        return $"title {TargetsHandler.Get(targets)} title {JsonSerializer.Serialize(text)}";
    }
    public static string ShowTitle(Targets targets, TextComponent[] text) {
        return $"title {TargetsHandler.Get(targets)} title {JsonSerializer.Serialize(text)}";
    }
    public static string ShowTitle(string targets, TextComponent text) {
        return $"title {targets} title {JsonSerializer.Serialize(text)}";
    }
    public static string ShowTitle(string targets, TextComponent[] text) {
        return $"title {targets} title {JsonSerializer.Serialize(text)}";
    }
#endregion
#region /title subtitle
    public static string Subtitle(Targets targets, TextComponent text) {
        return $"title {TargetsHandler.Get(targets)} subtitle {JsonSerializer.Serialize(text)}";
    }
    public static string Subtitle(Targets targets, TextComponent[] text) {
        return $"title {TargetsHandler.Get(targets)} subtitle {JsonSerializer.Serialize(text)}";
    }
    public static string Subtitle(string targets, TextComponent text) {
        return $"title {targets} subtitle {JsonSerializer.Serialize(text)}";
    }
    public static string Subtitle(string targets, TextComponent[] text) {
        return $"title {targets} subtitle {JsonSerializer.Serialize(text)}";
    }
#endregion
#region /title clear
    public static string Clear(Targets target) {
        return $"title {TargetsHandler.Get(target)} clear";
    }
    public static string Clear(string targets) {
        return $"title {targets} clear";
    }
#endregion
#region /title reset
    public static string Reset(Targets targets) {
        return $"title {TargetsHandler.Get(targets)} reset";
    }
    public static string Reset(string targets) {
        return $"title {targets} reset";
    }
#endregion
#region /title times
    public static string Times(Targets targets, string fadeIn, string stay, string fadeOut) {
        return $"title {TargetsHandler.Get(targets)} times {fadeIn} {stay} {fadeOut}";
    }
    public static string Times(string targets, string fadeIn, string stay, string fadeOut) {
        return $"title {targets} times {fadeIn} {stay} {fadeOut}";
    }
#endregion
}