using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core
{
    public static class Execute
    {
        const string[] defaults = null;
        public static void Write(string execute, string[] commands = defaults) => FunctionBuilder.Add(Str.Execute.Write(execute, commands));
        public static void As(string selector, string addition = "") => FunctionBuilder.Add(Str.Execute.As(selector, addition));
        public static void At(string selector, string addition = "") => FunctionBuilder.Add(Str.Execute.At(selector, addition));
        public static void Asat(string selector, string addition = "") => FunctionBuilder.Add(Str.Execute.Asat(selector, addition));
        public static void Unless(string arguments, string addition = "") => FunctionBuilder.Add(Str.Execute.Unless(arguments, addition));
        public static void If(string arguments, string addition = "") => FunctionBuilder.Add(Str.Execute.If(arguments, addition));
        public static void Summon(string entity, string[] pos, string addition = "") => FunctionBuilder.Add(Str.Execute.Summon(entity, pos, addition));
        public static void Store(string where, string at, string arguments, string addition = "") => FunctionBuilder.Add(Str.Execute.Store(where, at, arguments, addition));
        public static void StoreScore(string where, Score score, string selector = "", string addition = "") => FunctionBuilder.Add(Str.Execute.StoreScore(where, score, selector, addition));
    }
}
