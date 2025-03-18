using SteveSharp.Generic;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core
{
    public static class Entity
    {
        public static string Self(string match = "") { if (match == "") return "@s"; else return "@s[" + match + "]"; }
        public static string Everyone(string match = "") { if (match == "") return "@a"; else return "@a[" + match + "]"; }
        public static string Random(string match = "") { if (match == "") return "@r"; else return "@r[" + match + "]"; }
        public static string Closest(string match = "") { if (match == "") return "@p"; else return "@p[" + match + "]"; }
        public static string AllEntities(string match = "") { if (match == "") return "@e"; else return "@e[" + match + "]"; }
        /// <summary>
        /// This method selects an entity with specific matches, recommended if you want to select an entity with specific matches.
        /// </summary>
        /// <returns></returns>
        public static void Custom(string selector, int? limit = null, string[]? tags = null, string[]? scores = null, string? team = null, string? type = null, string? distance = null, string? area = null, string? level = null, string? gamemode = null, string? horizontalRotation = null, string? verticalRotation = null, string? sort = null)
        => FunctionBuilder.Add(Str.Entity.Custom(selector, limit, tags, scores, team, type, distance, area, level, gamemode, horizontalRotation, verticalRotation, sort));
        public static void Teleport(string selector, string to) => FunctionBuilder.Add(Str.Entity.Teleport(selector, to));
        public static void Summon(string entity, string[] pos, string nbt = "{}") => FunctionBuilder.Add(Str.Entity.Summon(entity, pos, nbt));
        public static void Summon(EntityEnum entity, string[] pos, string nbt = "{}") => FunctionBuilder.Add(Str.Entity.Summon(entity, pos, nbt));
        public static void AddTag(string selector, string tag) => FunctionBuilder.Add(Str.Entity.AddTag(selector, tag));
        public static void RemoveTag(string selector, string tag) => FunctionBuilder.Add(Str.Entity.RemoveTag(selector, tag));
        public static void Kill(string selector) => FunctionBuilder.Add(Str.Entity.Kill(selector));
    }
}