using SteveSharp.Generic;
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
        public static string Tell(Targets targets, string message) {
            return $"tell {TargetsHandler.Get(targets)} {message}";
        }
        public static string Tell(string targets, string message) {
            return $"tell {targets} {message}";
        }
        public static string Tellraw(Targets targets, TextComponent[] text)
        {
            string command = "tellraw " + TargetsHandler.Get(targets) + " " + JsonSerializer.Serialize(text);
            return command;
        }
        public static string Tellraw(string targets, TextComponent[] text)
        {
            string command = "tellraw " + targets + " " + JsonSerializer.Serialize(text);
            return command;
        }
        public static string Tellraw(Targets targets, TextComponent text)
        {
            string command = "tellraw " + TargetsHandler.Get(targets) + " " + JsonSerializer.Serialize(text);
            return command;
        }
        public static string Tellraw(string targets, TextComponent text)
        {
            string command = "tellraw " + targets + " " + JsonSerializer.Serialize(text);
            return command;
        }
    }
}
