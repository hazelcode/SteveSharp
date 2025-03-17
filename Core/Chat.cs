using SteveSharp.JsonShapes;
using System.Text.Json;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core
{
    public static class Chat
    {
        public static void Say(string msg) => FunctionBuilder.Add(Str.Chat.Say(msg));
        public static void Tell(string targets, string message) => FunctionBuilder.Add(Str.Chat.Tell(targets, message));
        public static void Tellraw(string selector, TextComponent[] text) => FunctionBuilder.Add(Str.Chat.Tellraw(selector, text));
        public static void Tellraw(string selector, TextComponent text) => FunctionBuilder.Add(Str.Chat.Tellraw(selector, text));
    }
}
