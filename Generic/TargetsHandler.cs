namespace SteveSharp.Generic;

internal static class TargetsHandler {
    internal static string Get(Targets targets) {
        Dictionary<Targets, string> TargetsStr = new() {
            {Targets.NearestPlayer, "@p"},
            {Targets.RandomPlayer, "@r"},
            {Targets.AllPlayers, "@a"},
            {Targets.AllEntities, "@e"},
            {Targets.Selected, "@s"}
        };

        return TargetsStr[targets];
    }
}