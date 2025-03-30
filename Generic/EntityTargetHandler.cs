namespace SteveSharp.Generic;

internal static class EntityTargetHandler {
    internal static string Get(EntityTarget targets) {
        Dictionary<EntityTarget, string> entityTargetStr = new() {
            {EntityTarget.NearestPlayer, "@p"},
            {EntityTarget.RandomPlayer, "@r"},
            {EntityTarget.AllPlayers, "@a"},
            {EntityTarget.AllEntities, "@e"},
            {EntityTarget.Selected, "@s"}
        };

        return entityTargetStr[targets];
    }
}