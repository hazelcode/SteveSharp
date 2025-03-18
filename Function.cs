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
        public static string Return(int i)
        {
            return "return " + i;
        }
        public static string Call(string function)
        {
            return "function " + function;
        }
        public static string Schedule(string function, string time, bool append = false, bool replace = false) {
            if(append && !replace) return $"schedule function {function} {time} append";
            else if(!append && replace) return $"schedule function {function} {time} replace";
            else return $"schedule function {function} {time}";
        }
        public string ScheduleSelf(string time, bool append = false, bool replace = false) => Schedule(Name, time, append, replace);
        public static string ClearSchedule(string function) => $"schedule clear {function}";
        public string ClearSchedule() => ClearSchedule(Name);

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
