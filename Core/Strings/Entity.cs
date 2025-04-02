using SteveSharp.Generic;

namespace SteveSharp.Core.Strings
{
    public static class Entity
    {
        /// <summary>
        /// This method selects an entity with specific matches, recommended if you want to select an entity with specific matches.
        /// </summary>
        /// <returns></returns>
        public static string Custom(Targets targets, int? limit = null, string[]? tags = null, string[]? scores = null, string? team = null, string? type = null, string? distance = null, string? area = null, string? level = null, string? gamemode = null, string? horizontalRotation = null, string? verticalRotation = null, string? sort = null)
            => Custom(TargetsHandler.Get(targets), limit, tags, scores, team, type, distance, area, level, gamemode, horizontalRotation, verticalRotation, sort);
        /// <summary>
        /// This method selects an entity with specific matches, recommended if you want to select an entity with specific matches.
        /// </summary>
        /// <returns></returns>
        public static string Custom(string targets, int? limit = null, string[]? tags = null, string[]? scores = null, string? team = null, string? type = null, string? distance = null, string? area = null, string? level = null, string? gamemode = null, string? horizontalRotation = null, string? verticalRotation = null, string? sort = null) {
            string match = "";
            match += targets + "[";
            if(limit != null) match += "limit=" + limit + ',';
            if(tags?.Length >= 1){
                foreach(string tag in tags){
                    match += "tag=" + tag + ",";
                }
            }
            if(scores?.Length >= 1){
                match += "scores={";
                foreach(string score in scores){
                    match += score + ',';
                }
                match += "},";
            }
            if(team != null) match += "team=" + team + ',';
            if(type != null && targets != "@a" || targets != "@r" || targets != "@p")
                match += "type=" + type + ',';
            if(distance != null) match += "distance=" + distance + ',';
            if(area != null) match += area + ',';
            if(level != null) match += "level=" + level + ',';
            if(gamemode != null && targets != "@e") match += "gamemode=" + gamemode + ',';
            if(horizontalRotation != null) match += "y_rotation=" + horizontalRotation + ',';
            if(verticalRotation != null) match += "x_rotation=" + verticalRotation + ',';
            if(sort != null) match += "sort=" + sort + ',';
            if (match.EndsWith(',')) match.Remove(match.Length - 1);
            match += ']';
            return match;
        }
        public static string Teleport(Targets targets, string to)
        {
            return $"tp {TargetsHandler.Get(targets)} {to}";
        }
        public static string Teleport(string targets, string to)
        {
            return $"tp {targets} {to}";
        }
        public static string Summon(EntityEnum entity, (int X, int Y, int Z) pos, string nbt = "{}")
        {
            return $"summon {EntityHandler.Get(entity)} {pos.X} {pos.Y} {pos.Z} {nbt}";
        }
        public static string Summon(EntityEnum entity, (string X, string Y, string Z) rel, string nbt = "{}")
        {
            return $"summon {EntityHandler.Get(entity)} {rel.X} {rel.Y} {rel.Z} {nbt}";
        }
        public static string Summon(EntityEnum entity, string[] pos, string nbt = "{}") {
            return Summon(EntityHandler.Get(entity), pos, nbt);
        }
        public static string Summon(string entity, (int X, int Y, int Z) pos, string nbt = "{}")
        {
            return $"summon {entity} {pos.X} {pos.Y} {pos.Z} {nbt}";
        }
        public static string Summon(string entity, (string X, string Y, string Z) rel, string nbt = "{}")
        {
            return $"summon {entity} {rel.X} {rel.Y} {rel.Z} {nbt}";
        }
        public static string Summon(string entity, string[] pos, string nbt = "{}")
        {
            return $"summon {entity} {pos[0]} {pos[1]} {pos[2]} {nbt}";
        }
        public static string AddTag(Targets targets, string tag)
        {
            return $"tag {TargetsHandler.Get(targets)} add {tag}";
        }
        public static string AddTag(string targets, string tag)
        {
            return $"tag {targets} add {tag}";
        }
        public static string RemoveTag(Targets targets, string tag)
        {
            return $"tag {TargetsHandler.Get(targets)} remove {tag}";
        }
        public static string RemoveTag(string targets, string tag)
        {
            return $"tag {targets} remove {tag}";
        }
        public static string Kill(Targets targets)
        {
            return $"kill {TargetsHandler.Get(targets)}";
        }
        public static string Kill(string targets)
        {
            return $"kill {targets}";
        }
    }
}
