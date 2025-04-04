using SteveSharp.Generic;

namespace SteveSharp.Core;

public class ScoreEnum() : Dictionary<string, int> {
    public string? Name { get; set; }
    public Dictionary<int, string> EnumMap { get; set; } = [];
    public void Switch(Targets targets, Dictionary<int, string[]> cases) {
        List<string> commands = [];

        foreach(var codeBlock in cases) {
            foreach(var command in codeBlock.Value) {
                commands.Add($"execute as {TargetsHandler.Get(targets)} if score @s {Name} = #{EnumMap[codeBlock.Key]} {Name} run {command}");
            }
        }

        FunctionBuilder.Add(commands);
    }
    public void Switch(Targets asat, Dictionary<int, List<string>> cases) {
        List<string> commands = [];

        foreach(var codeBlock in cases) {
            foreach(var command in codeBlock.Value) {
                commands.Add($"execute as {TargetsHandler.Get(asat)} at @s if score @s {Name} = #{EnumMap[codeBlock.Key]} {Name} run {command}");
            }
        }

        FunctionBuilder.Add(commands);
    }
}