using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core
{
    public class Score
    {
        public int count = 0;
        public string id;
        public string type;
        public string name;
        public Score(string id, string type = "dummy", string name = "", int count = 0)
        {
            this.id = id;
            this.count = count;
            this.type = type;
            this.name = name;
        }
        public void AddObjective() => FunctionBuilder.Add(Str.Score.AddObjective(id, type, name));
        public static void AddObjective(string id, string type, string name) => FunctionBuilder.Add(Str.Score.AddObjective(id, type, name));
        public static void AddObjectives(Score[] scores) {
            string commands = "";
            foreach(Score score in scores)
            {
                commands += Str.Score.AddObjective(score.id, score.type, score.name) + "\n";
            }
            FunctionBuilder.Add(commands);
        }
        public void Set(int count, string selector = "")
        {
            Set(id, count, selector);
        }
        public static void Set(string id, int count, string selector = "")
        {
            FunctionBuilder.Add(Str.Score.Set(id, count, selector));
        }
        public void Add(int count, string selector = "")
        {
            Add(id, count, selector);
        }
        public static void Add(string id, int count, string selector = "")
        {
            FunctionBuilder.Add(Str.Score.Add(id, count, selector));
        }
        public void Remove(int count, string selector = "")
        {
            Remove(id, count, selector);
        }
        public static void Remove(string id, int count, string selector = "")
        {
            FunctionBuilder.Add(Str.Score.Remove(id, count, selector));
        }
        public void Reset(string selector = "")
        {
            Reset(id, selector);
        }
        public static void Reset(string id, string selector = "")
        {
            FunctionBuilder.Add(Str.Score.Reset(id, selector));
        }
        /// <summary>
        /// Only for use in scores={} cases
        /// </summary>
        /// <returns></returns>
        public string Matches(int value){
            return this.id + '=' + value;
        }
    }
}
