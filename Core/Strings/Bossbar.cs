using SteveSharp.JsonShapes;
using SteveSharp.Generic;
using System.Text.Json;
using BB = SteveSharp.Core.Bossbar;

namespace SteveSharp.Core.Strings;

public class Bossbar
{
    public string? Id { get; set; }
    public static string Add(string id, TextComponent text) => $"bossbar add {id} {JsonSerializer.Serialize(text)}";
    public static string Add(string id, TextComponent[] text) => $"bossbar add {id} {JsonSerializer.Serialize(text)}";
    public static string Get(string id, BB.GetField field)
    {
        Dictionary<BB.GetField, string> fieldStr = new() {
            {BB.GetField.Max, "max"},
            {BB.GetField.Players, "players"},
            {BB.GetField.Value, "value"},
            {BB.GetField.Visible, "visible"}
        };
        return $"bossbar get {id} {fieldStr[field]}";
    }
    public static string Get(string id, string field) => $"bossbar get {id} {field}";
    public static string List() => "bossbar list";
    public static string Remove(string id) => $"bossbar remove {id}";
    public static string SetColor(string id, Color color) => $"bossbar set {id} color {ColorHandler.Get(color)}";
    public static string SetColor(string id, string color) => $"bossbar set {id} color {color}";
    public static string SetMax(string id, int max) => $"bossbar set {id} max {max}";
    public static string SetName(string id, TextComponent name) => $"bossbar set {id} name {JsonSerializer.Serialize(name)}";
    public static string SetName(string id, TextComponent[] name) => $"bossbar set {id} name {JsonSerializer.Serialize(name)}";
    public static string SetPlayers(string id, string targets) => $"bossbar set {id} players {targets}";
    public static string SetStyle(string id, BB.Style style)
    {
        Dictionary<BB.Style, string> styleStr = new() {
            {BB.Style.Notched6, "notched_6"},
            {BB.Style.Notched10, "notched_10"},
            {BB.Style.Notched12, "notched_12"},
            {BB.Style.Notched20, "notched_20"}
        };
        return $"bossbar set {id} style {styleStr[style]}";
    }
    public static string SetStyle(string id, string style) => $"bossbar set {id} style {style}";
    public static string SetValue(string id, int value) => $"bossbar set {id} value {value}";
    public static string SetVisible(string id, bool visible) => $"bossbar set {id} visible {visible.ToString().ToLower()}";
    public Bossbar(string id)
    {
        Id = id;
    }
    public string Add(TextComponent text) => Add(this.Id!, text);
    public string Add(TextComponent[] text) => Add(this.Id!, text);
    public string Get(BB.GetField field) => Get(this.Id!, field);
    public string Get(string field) => Get(this.Id!, field);
    public string SetColor(Color color) => SetColor(this.Id!, color);
    public string SetColor(string color) => SetColor(this.Id!, color);
    public string SetMax(int max) => SetMax(this.Id!, max);
    public string SetName(TextComponent name) => SetName(this.Id!, name);
    public string SetName(TextComponent[] name) => SetName(this.Id!, name);
    public string SetPlayers(string targets) => SetPlayers(this.Id!, targets);
    public string SetStyle(BB.Style style) => SetStyle(this.Id!, style);
    public string SetStyle(string style) => SetStyle(this.Id!, style);
    public string SetValue(int value) => SetValue(this.Id!, value);
    public string SetVisible(bool visible) => SetVisible(this.Id!, visible);
}