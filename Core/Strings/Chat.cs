using SteveSharp.JsonShapes;
using System.Text.Json;

namespace SteveSharp.Core.Strings
{
    public static class Chat
    {
        public static string Say(string msg)
        {
            return $"say {msg}";
        }
        public static string Tellraw(string selector, TextComponent[] text)
        {
            string command = "tellraw " + selector + " " + JsonSerializer.Serialize(text);
            return command;
        }
        public static string Tellraw(string selector, TextComponent text)
        {
            string command = "tellraw " + selector + " " + JsonSerializer.Serialize(text);
            return command;
        }
    }
}
