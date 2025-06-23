using Str = SteveSharp.Core.Strings;

namespace SteveSharp
{
    public class Function
    {
        public string Name = "";
        public Func<FunctionContext, string[]> Body { get; set; }
        public Function(string name, Func<FunctionContext, string[]> body)
        {
            Name = name;
            Body = body;
            Displays.NewFunction(name);
        }
        public static void Return(int i) => FunctionBuilder.Add(Str.Function.Return(i));
        public static void Call(string function) => FunctionBuilder.Add(Str.Function.Call(function));
        public static void Schedule(string function, string time, bool append = false, bool replace = false) {
            FunctionBuilder.Add(Str.Function.Schedule(function, time, append, replace));
        }
        public void ScheduleSelf(string time, bool append = false, bool replace = false) => FunctionBuilder.Add(Str.Function.Schedule(Name, time, append, replace));
        public static void ClearSchedule(string function) => FunctionBuilder.Add(Str.Function.ClearSchedule(function));
        public void ClearSchedule() => ClearSchedule(Name);

        /// <summary>
        /// Extend to another function from the current function
        /// </summary>
        /// <param name="function">The new function to assign</param>
        /// <param name="ctx">The actual function context</param>
        public static void Extend(Function function, FunctionContext ctx) {
            FunctionBuilder.Add("function "+function.Name);
            
            // List the another function to build on project construction.
            ctx.Project.FunctionIndex.Add(function.Name, function);
        }
    }
}
