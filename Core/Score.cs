using SteveSharp.Generic;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core
{
    public class Score
    {
        public string id;
        public string type;
        public string name;
        public Score(string id, string type = "dummy", string name = "")
        {
            this.id = id;
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
        public void Set(int count, Targets targets)
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
        public void Add(int count, Targets targets)
        {
            FunctionBuilder.Add(Str.Score.Add(id, count, targets));
        }
        public static void Add(string id, int count, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Add(id, count, targets));
        }
        public static void Add(string id, int count, Targets targets)
        {
            FunctionBuilder.Add(Str.Score.Add(id, count, targets));
        }
        public void Remove(int count, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Remove(id, count, targets));
        }
        public void Remove(int count, Targets targets)
        {
            FunctionBuilder.Add(Str.Score.Remove(id, count, targets));
        }
        public static void Remove(string id, int count, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Remove(id, count, targets));
        }
        public static void Remove(string id, int count, Targets targets)
        {
            FunctionBuilder.Add(Str.Score.Remove(id, count, targets));
        }
        public void Reset(string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Reset(id, targets));
        }
        public void Reset(Targets targets)
        {
            FunctionBuilder.Add(Str.Score.Reset(id, targets));
        }
        public static void Reset(string id, string targets = "")
        {
            FunctionBuilder.Add(Str.Score.Reset(id, targets));
        }
        public static void Reset(string id, Targets targets)
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
#region operators
        public static Score operator + (Score a, int b) {
            FunctionBuilder.Add($"scoreboard players add #{a.id} {a.id} {b}");
            return a;
        }
        public static Score operator - (Score a, int b) {
            FunctionBuilder.Add($"scoreboard players remove #{a.id} {a.id} {b}");
            return a;
        }
        public static Score operator * (Score a, int b) {
            FunctionBuilder.Add(
                $"scoreboard players set #{a.id}_temp {a.id} {b}\n"+
                $"scoreboard players operation #{a.id} {a.id} *= #{a.id}_temp {a.id}\n"+
                $"scoreboard players reset #{a.id}_temp {a.id}"
            );
            return a;
        }
        public static Score operator / (Score a, int b) {
            FunctionBuilder.Add(
                $"scoreboard players set #{a.id}_temp {a.id} {b}\n"+
                $"scoreboard players operation #{a.id} {a.id} /= #{a.id}_temp {a.id}\n"+
                $"scoreboard players reset #{a.id}_temp {a.id}"
            );
            return a;
        }
        public static Score operator % (Score a, int b) {
            FunctionBuilder.Add(
                $"scoreboard players set #{a.id}_temp {a.id} {b}\n"+
                $"scoreboard players operation #{a.id} {a.id} %= #{a.id}_temp {a.id}\n"+
                $"scoreboard players reset #{a.id}_temp {a.id}"
            );
            return a;
        }
        public static Score operator + (Score a, Score b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} += #{b.id} {b.id}");
            return a;
        }
        public static Score operator - (Score a, Score b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} -= #{b.id} {b.id}");
            return a;
        }
        public static Score operator * (Score a, Score b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} *= #{b.id} {b.id}");
            return a;
        }
        public static Score operator / (Score a, Score b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} /= #{b.id} {b.id}");
            return a;
        }
        public static Score operator % (Score a, Score b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} %= #{b.id} {b.id}");
            return a;
        }
        public static Score operator + (Score a, Targets b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} += {TargetsHandler.Get(b)} {a.id}");
            return a;
        }
        public static Score operator - (Score a, Targets b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} -= {TargetsHandler.Get(b)} {a.id}");
            return a;
        }
        public static Score operator * (Score a, Targets b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} *= {TargetsHandler.Get(b)} {a.id}");
            return a;
        }
        public static Score operator / (Score a, Targets b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} /= {TargetsHandler.Get(b)} {a.id}");
            return a;
        }
        public static Score operator % (Score a, Targets b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} %= {TargetsHandler.Get(b)} {a.id}");
            return a;
        }
        public static Score operator + (Score a, string b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} += {b} {a.id}");
            return a;
        }
        public static Score operator - (Score a, string b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} -= {b} {a.id}");
            return a;
        }
        public static Score operator * (Score a, string b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} *= {b} {a.id}");
            return a;
        }
        public static Score operator / (Score a, string b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} /= {b} {a.id}");
            return a;
        }
        public static Score operator % (Score a, string b) {
            FunctionBuilder.Add($"scoreboard players operation #{a.id} {a.id} %= {b} {a.id}");
            return a;
        }
        public static bool operator == (Score a, int b) {
            FunctionBuilder.Add($"execute if score #{a.id} myVariable matches {b} run \\");
            return true;
        }
        public static bool operator != (Score a, int b) {
            FunctionBuilder.Add($"execute unless score #{a.id} {a.id} matches {b} run \\");
            return true;
        }
        public static bool operator >= (Score a, int b) {
            FunctionBuilder.Add($"execute if score #{a.id} {a.id} matches {b}.. run \\");
            return true;
        }
        public static bool operator <= (Score a, int b) {
            FunctionBuilder.Add($"execute if score #{a.id} {a.id} matches ..{b} run \\");
            return true;
        }
        public static bool operator > (Score a, int b) {
            FunctionBuilder.Add($"execute unless score #{a.id} {a.id} matches ..{b}");
            return true;
        }
        public static bool operator < (Score a, int b) {
            FunctionBuilder.Add($"execute unless score #{a.id} {a.id} matches {b}..");
            return true;
        }
        public static bool operator == (Score a, Score b) {
            FunctionBuilder.Add($"execute if score #{a.id} {a.id} = #{b.id} {b.id} run \\");
            return true;
        }
        public static bool operator != (Score a, Score b) {
            FunctionBuilder.Add($"execute unless score #{a.id} {a.id} = #{b.id} {b.id} run \\");
            return true;
        }
        public static bool operator >= (Score a, Score b) {
            FunctionBuilder.Add($"execute if score #{a.id} {a.id} >= #{b.id} {b.id} run \\");
            return true;
        }
        public static bool operator <= (Score a, Score b) {
            FunctionBuilder.Add($"execute if score #{a.id} {a.id} <= #{b.id} {b.id} run \\");
            return true;
        }
        public static bool operator > (Score a, Score b) {
            FunctionBuilder.Add($"execute if score #{a.id} {a.id} > #{b.id} {b.id} run \\");
            return true;
        }
        public static bool operator < (Score a, Score b) {
            FunctionBuilder.Add($"execute if score #{a.id} {a.id} < #{b.id} {b.id} run \\");
            return true;
        }
#endregion
        public override bool Equals(object? obj) {
            if(obj is Score s) {
                return true;
            } else {
                return false;
            }
        }

    public override int GetHashCode() => GetHashCode();
    }
}
