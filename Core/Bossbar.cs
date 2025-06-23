using System.Text.Json;
using SteveSharp.Generic;
using SteveSharp.JsonShapes;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core;

public class Bossbar
{
    public string? Id { get; set; }
    public enum GetField
    {
        Max,
        Players,
        Value,
        Visible
    }
    public enum Style
    {
        Notched6,
        Notched10,
        Notched12,
        Notched20
    }
    public static void Add(string id, TextComponent text) => FunctionBuilder.Add(Str.Bossbar.Add(id, text)); 
    public static void Add(string id, TextComponent[] text) => FunctionBuilder.Add(Str.Bossbar.Add(id, text));
    public static void Get(string id, GetField field) => FunctionBuilder.Add(Str.Bossbar.Get(id, field));
    public static void Get(string id, string field) => FunctionBuilder.Add(Str.Bossbar.Get(id, field));
    public static void List() => FunctionBuilder.Add(Str.Bossbar.List());
    public static void Remove(string id) => FunctionBuilder.Add(Str.Bossbar.Remove(id));
    public static void SetColor(string id, Color color) => FunctionBuilder.Add(Str.Bossbar.SetColor(id, color));
    public static void SetColor(string id, string color) => FunctionBuilder.Add(Str.Bossbar.SetColor(id, color));
    public static void SetMax(string id, int max) => FunctionBuilder.Add(Str.Bossbar.SetMax(id, max));
    public static void SetName(string id, TextComponent name) => FunctionBuilder.Add(Str.Bossbar.SetName(id, name));
    public static void SetName(string id, TextComponent[] name) => FunctionBuilder.Add(Str.Bossbar.SetName(id, name));
    public static void SetPlayers(string id, string targets) => FunctionBuilder.Add(Str.Bossbar.SetPlayers(id, targets));
    public static void SetStyle(string id, Style style) => FunctionBuilder.Add(Str.Bossbar.SetStyle(id, style));
    public static void SetStyle(string id, string style) => FunctionBuilder.Add(Str.Bossbar.SetStyle(id, style));
    public static void SetValue(string id, int value) => FunctionBuilder.Add(Str.Bossbar.SetValue(id, value));
    public static void SetVisible(string id, bool visible) => FunctionBuilder.Add(Str.Bossbar.SetVisible(id, visible));
    public Bossbar(string id)
    {
        Id = id;
    }
    public void Add(TextComponent text) => Add(this.Id!, text);
    public void Add(TextComponent[] text) => Add(this.Id!, text);
    public void Get(GetField field) => Get(this.Id!, field);
    public void Get(string field) => Get(this.Id!, field);
    public void SetColor(Color color) => SetColor(this.Id!, color);
    public void SetColor(string color) => SetColor(this.Id!, color);
    public void SetMax(int max) => SetMax(this.Id!, max);
    public void SetName(TextComponent name) => SetName(this.Id!, name);
    public void SetName(TextComponent[] name) => SetName(this.Id!, name);
    public void SetPlayers(string targets) => SetPlayers(this.Id!, targets);
    public void SetStyle(Style style) => SetStyle(this.Id!, style);
    public void SetStyle(string style) => SetStyle(this.Id!, style);
    public void SetValue(int value) => SetValue(this.Id!, value);
    public void SetVisible(bool visible) => SetVisible(this.Id!, visible);
}