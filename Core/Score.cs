using SteveSharp.Generic;
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
        public void Set(int count, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Set(id, count, targets));
        }
        public void Set(int count, EntityTarget targets)
        {
            FunctionBuilder.Add(Str.Score.Set(id, count, targets));
        }
        public static void Set(string id, int count, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Set(id, count, targets));
        }
        public void Add(int count, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Add(id, count, targets));
        }
        public void Add(int count, EntityTarget targets)
        {
            FunctionBuilder.Add(Str.Score.Add(id, count, targets));
        }
        public static void Add(string id, int count, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Add(id, count, targets));
        }
        public static void Add(string id, int count, EntityTarget targets)
        {
            FunctionBuilder.Add(Str.Score.Add(id, count, targets));
        }
        public void Remove(int count, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Remove(id, count, targets));
        }
        public void Remove(int count, EntityTarget targets)
        {
            FunctionBuilder.Add(Str.Score.Remove(id, count, targets));
        }
        public static void Remove(string id, int count, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Remove(id, count, targets));
        }
        public static void Remove(string id, int count, EntityTarget targets)
        {
            FunctionBuilder.Add(Str.Score.Remove(id, count, targets));
        }
        public void Reset(string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Reset(id, targets));
        }
        public void Reset(EntityTarget targets)
        {
            FunctionBuilder.Add(Str.Score.Reset(id, targets));
        }
        public static void Reset(string id, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Reset(id, targets));
        }
        public static void Reset(string id, EntityTarget targets)
        {
            FunctionBuilder.Add(Str.Score.Reset(id, targets));
        }
        /// <summary>
        /// Only for use in scores={} cases
        /// </summary>
        /// <returns></returns>
        public string Matches(int value){
            return this.id + '=' + value;
        }
        /// <summary>
        /// Only for use in scores={} cases
        /// </summary>
        /// <returns></returns>
        public static string Matches(string id, int value){
            return id + '=' + value;
        }
    }
}
