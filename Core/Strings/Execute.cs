using SteveSharp.Generic;
using Core = SteveSharp.Core;

namespace SteveSharp.Core.Strings
{
    public static class Execute
    {
        const string[] defaults = null;
        public static string Write(string execute, string[] commands = defaults)
        {
            string allCommands = "";
            foreach (string command in commands)
            {
                allCommands += "execute " + execute + "run " + command + "\n";
            }
            return allCommands;
        }
        public static string As(EntityTarget targets, string addition = "")
        {
            return "as " + EntityTargetHandler.Get(targets) + " " + addition;
        }
        public static string As(string targets, string addition = "")
        {
            return "as " + targets + " " + addition;
        }
        public static string At(EntityTarget targets, string addition = "")
        {
            return "at " + EntityTargetHandler.Get(targets) + " " + addition;
        }
        public static string At(string targets, string addition = "")
        {
            return "at " + targets + " " + addition;
        }
        public static string Asat(EntityTarget targets, string addition = "")
        {
            return "as " + EntityTargetHandler.Get(targets) + " at @s " + addition;
        }
        public static string Asat(string targets, string addition = "")
        {
            return "as " + targets + " at @s " + addition;
        }
        public static string Unless(string arguments, string addition = "")
        {
            return "unless " + arguments + " " + addition;
        }
        public static string If(string arguments, string addition = "")
        {
            return "if " + arguments + " " + addition;
        }
        public static string Summon(EntityEnum entity, string[] pos, string addition = "")
        {
            return "summon " + EntityHandler.Get(entity) + " " + pos[0] + " " + pos[1] + " " + pos[2] + " " + addition;
        }
        public static string Summon(string entity, string[] pos, string addition = "")
        {
            return "summon " + entity + " " + pos[0] + " " + pos[1] + " " + pos[2] + " " + addition;
        }
        public static string Store(string where, string at, string arguments, string addition = "")
        {
            return "store " + where + " " + at + " " + arguments + " " + addition;
        }
        public static string StoreScore(string where, Core.Score score, EntityTarget targets, string addition = "")
        {
            return "store " + where + " score " + EntityTargetHandler.Get(targets) + " " + score.id + " " + addition;
        }
        public static string StoreScore(string where, Core.Score score, string targets = "", string addition = "")
        {
            if (targets == "")
            {
                return "store " + where + " score " + "#" + score.id + " " + score.id + " " + addition;
            }
            else
            {
                return "store " + where + " score " + targets + " " + score.id + " " + addition;
            }
        }
    }
}
