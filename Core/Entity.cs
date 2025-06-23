using SteveSharp.Generic;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core
{
    public static class Entity
    {
        public static string SelectedMatch(string match) => "@s[" + match + "]";
        public static string AllPlayersMatch(string match) => "@a[" + match + "]";
        public static string RandomPlayerMatch(string match) => "@r[" + match + "]";
        public static string NearestPlayerMatch(string match) => "@p[" + match + "]";
        public static string AllEntitiesMatch(string match) => "@e[" + match + "]";
        /// <summary>
        /// This method selects an entity with specific matches, recommended if you want to select an entity with specific matches.
        /// </summary>
        /// <returns></returns>
        public static void Custom(Targets targets, int? limit = null, string[]? tags = null, string[]? scores = null, string? team = null, string? type = null, string? distance = null, string? area = null, string? level = null, string? gamemode = null, string? horizontalRotation = null, string? verticalRotation = null, string? sort = null)
        => FunctionBuilder.Add(Str.Entity.Custom(targets, limit, tags, scores, team, type, distance, area, level, gamemode, horizontalRotation, verticalRotation, sort));
        public static void Custom(string targets, int? limit = null, string[]? tags = null, string[]? scores = null, string? team = null, string? type = null, string? distance = null, string? area = null, string? level = null, string? gamemode = null, string? horizontalRotation = null, string? verticalRotation = null, string? sort = null)
        => FunctionBuilder.Add(Str.Entity.Custom(targets, limit, tags, scores, team, type, distance, area, level, gamemode, horizontalRotation, verticalRotation, sort));
        public static void Teleport(Targets targets, string to) => FunctionBuilder.Add(Str.Entity.Teleport(targets, to));
        public static void Teleport(string targets, string to) => FunctionBuilder.Add(Str.Entity.Teleport(targets, to));
        public static void Summon(EntityEnum entity, (int X, int Y, int Z) pos, string nbt = "{}") => FunctionBuilder.Add(Str.Entity.Summon(entity, pos, nbt));
        public static void Summon(EntityEnum entity, (string X, string Y, string Z) rel, string nbt = "{}") => FunctionBuilder.Add(Str.Entity.Summon(entity, rel, nbt));
        public static void Summon(EntityEnum entity, string[] pos, string nbt = "{}") => FunctionBuilder.Add(Str.Entity.Summon(entity, pos, nbt));
        public static void Summon(string entity, (int X, int Y, int Z) pos, string nbt = "{}") => FunctionBuilder.Add(Str.Entity.Summon(entity, pos, nbt));
        public static void Summon(string entity, (string X, string Y, string Z) rel, string nbt = "{}") => FunctionBuilder.Add(Str.Entity.Summon(entity, rel, nbt));
        public static void Summon(string entity, string[] pos, string nbt = "{}") => FunctionBuilder.Add(Str.Entity.Summon(entity, pos, nbt));
        public static void AddTag(Targets targets, string tag) => FunctionBuilder.Add(Str.Entity.AddTag(targets, tag));
        public static void AddTag(string targets, string tag) => FunctionBuilder.Add(Str.Entity.AddTag(targets, tag));
        public static void RemoveTag(Targets targets, string tag) => FunctionBuilder.Add(Str.Entity.RemoveTag(targets, tag));
        public static void RemoveTag(string targets, string tag) => FunctionBuilder.Add(Str.Entity.RemoveTag(targets, tag));
        public static void Kill(Targets targets) => FunctionBuilder.Add(Str.Entity.Kill(targets));
        public static void Kill(string targets) => FunctionBuilder.Add(Str.Entity.Kill(targets));
    }
}