using SteveSharp.JsonShapes;
using System.Text.Json;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core
{
    public static class Chat
    {
        public static void Say(string msg) => FunctionBuilder.Add(Str.Chat.Say(msg));
        public static void Out(string selector, TextComponent[] text) => FunctionBuilder.Add(Str.Chat.Out(selector, text));
        public static void Out(string selector, TextComponent text) => FunctionBuilder.Add(Str.Chat.Out(selector, text));
    }
}
