namespace SteveSharp.Core.Strings
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
        public string AddObjective()
        {
            return AddObjective(id, type, name);
        }
        public static string AddObjective(string id, string type, string name)
        {
            return $"scoreboard objectives add {id} {type} {name}";
        }
        public static string AddObjectives(Score[] scores)
        {
            string commands = "";
            foreach(Score score in scores)
            {
                commands += $"scoreboard objectives add {score.id} {score.type} {score.name}\n";
            }
            return commands;
        }
        public string Set(int count, string selector = "")
        {
            return Set(id, count, selector);
        }
        public static string Set(string id, int count, string selector = "")
        {
            if(selector == "")
            {
                return $"scoreboard players set #{id} {id} {count}";
            } else
            {
                return $"scoreboard players set {selector} {id} {count}";
            }
        }
        public string Add(int count, string selector = "")
        {
            return Add(id, count, selector);
        }
        public static string Add(string id, int count, string selector = "")
        {
            if (selector == "")
            {
                return $"scoreboard players add #{id} {id} {count}";
            }
            else
            {
                return $"scoreboard players add {selector} {id} {count}";
            }
        }
        public string Remove(int count, string selector = "")
        {
            return Remove(id, count, selector);
        }
        public static string Remove(string id, int count, string selector = "")
        {
            if (selector == "")
            {
                return $"scoreboard players remove #{id} {id} {count}";
            }
            else
            {
                return $"scoreboard players remove {selector} {id} {count}";
            }
        }
        public string Reset(string selector = "")
        {
            return Reset(id, selector);
        }
        public static string Reset(string id, string selector = "")
        {
            if (selector == "")
            {
                return $"scoreboard players reset #{id} {id}";
            }
            else
            {
                return $"scoreboard players reset {selector} {id}";
            }
        }
        /// <summary>
        /// Only for use in scores={} cases
        /// </summary>
        /// <returns></returns>
        public string Matches(int value){
            return Matches(id, value);
        }
        public static string Matches(string id, int value){
            return id + '=' + value;
        }
    }
}
