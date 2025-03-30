using SteveSharp.Generic;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core
{
    public static class Execute
    {
        const string[] defaults = null;
        public static void Write(string execute, string[] commands = defaults) => FunctionBuilder.Add(Str.Execute.Write(execute, commands));
        public static void As(EntityTarget targets, string addition = "") => FunctionBuilder.Add(Str.Execute.As(targets, addition));
        public static void As(string targets, string addition = "") => FunctionBuilder.Add(Str.Execute.As(targets, addition));
        public static void At(EntityTarget targets, string addition = "") => FunctionBuilder.Add(Str.Execute.At(targets, addition));
        public static void At(string targets, string addition = "") => FunctionBuilder.Add(Str.Execute.At(targets, addition));
        public static void Asat(EntityTarget targets, string addition = "") => FunctionBuilder.Add(Str.Execute.Asat(targets, addition));
        public static void Asat(string targets, string addition = "") => FunctionBuilder.Add(Str.Execute.Asat(targets, addition));
        public static void Unless(string arguments, string addition = "") => FunctionBuilder.Add(Str.Execute.Unless(arguments, addition));
        public static void If(string arguments, string addition = "") => FunctionBuilder.Add(Str.Execute.If(arguments, addition));
        public static void Summon(string entity, string[] pos, string addition = "") => FunctionBuilder.Add(Str.Execute.Summon(entity, pos, addition));
        public static void Store(string where, string at, string arguments, string addition = "") => FunctionBuilder.Add(Str.Execute.Store(where, at, arguments, addition));
        public static void StoreScore(string where, Score score, EntityTarget targets, string addition = "") => FunctionBuilder.Add(Str.Execute.StoreScore(where, score, targets, addition));
        public static void StoreScore(string where, Score score, string targets = "", string addition = "") => FunctionBuilder.Add(Str.Execute.StoreScore(where, score, targets, addition));
    }
}
