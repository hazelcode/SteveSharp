using SteveSharp.Generic;

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
        public static string AddObjective(string id, string type, string name = "")
        {
            if(name == "") {
                return $"scoreboard objectives add {id} {type}";
            } else {
                return $"scoreboard objectives add {id} {type} {name}";
            }
        }
        public static string AddObjectives(Score[] scores)
        {
            string commands = "";
            foreach(Score score in scores)
            {
                commands += AddObjective(score.id, score.type, score.name) + "\n";
            }
            return commands;
        }
        public string Set(int count, string targets = "")
        {
            return Set(id, count, targets);
        }
        public string Set(int count, EntityTarget targets)
        {
            return Set(id, count, EntityTargetHandler.Get(targets));
        }
        public static string Set(string id, int count, string targets = "")
        {
            if(targets == "")
            {
                return $"scoreboard players set #{id} {id} {count}";
            } else
            {
                return $"scoreboard players set {targets} {id} {count}";
            }
        }
        public static string Set(string id, int count, EntityTarget targets)
        {
            return $"scoreboard players set {EntityTargetHandler.Get(targets)} {id} {count}";
        }
        public string Add(int count, string targets = "")
        {
            return Add(id, count, targets);
        }
        public string Add(int count, EntityTarget targets) {
            return Add(id, count, EntityTargetHandler.Get(targets));
        }
        public static string Add(string id, int count, string targets = "")
        {
            if (targets == "")
            {
                return $"scoreboard players add #{id} {id} {count}";
            }
            else
            {
                return $"scoreboard players add {targets} {id} {count}";
            }
        }
        public static string Add(string id, int count, EntityTarget targets)
        {
            return $"scoreboard players add {EntityTargetHandler.Get(targets)} {id} {count}";
        }
        public string Remove(int count, string targets = "")
        {
            return Remove(id, count, targets);
        }
        public string Remove(int count, EntityTarget targets)
        {
            return Remove(id, count, targets);
        }
        public static string Remove(string id, int count, string targets = "")
        {
            if (targets == "")
            {
                return $"scoreboard players remove #{id} {id} {count}";
            }
            else
            {
                return $"scoreboard players remove {targets} {id} {count}";
            }
        }
        public static string Remove(string id, int count, EntityTarget targets)
        {
            return $"scoreboard players remove {EntityTargetHandler.Get(targets)} {id} {count}";
        }
        public string Reset(string targets = "")
        {
            return Reset(id, targets);
        }
        public string Reset(EntityTarget targets)
        {
            return Reset(id, EntityTargetHandler.Get(targets));
        }
        public static string Reset(string id, string targets = "")
        {
            if (targets == "")
            {
                return $"scoreboard players reset #{id} {id}";
            }
            else
            {
                return $"scoreboard players reset {targets} {id}";
            }
        }
        public static string Reset(string id, EntityTarget targets)
        {
            return $"scoreboard players reset {EntityTargetHandler.Get(targets)} {id}";
        }
        /// <summary>
        /// Only for use in scores={} cases
        /// </summary>
        /// <returns></returns>
        public string Matches(int value){
            return Matches(id, value);
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
