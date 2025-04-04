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

    public void Reset(Targets targets) => FunctionBuilder.Add($"scoreboard players reset {TargetsHandler.Get(targets)} {Name}");
    public void Reset(string targets) => FunctionBuilder.Add($"scoreboard players reset {targets} {Name}");
    public void Next(Targets targets) {
        FunctionBuilder.Add([
            $"execute as {TargetsHandler.Get(targets)} if score @s {Name} >= #{EnumMap[EnumMap.Count-1]} {Name} run scoreboard players set @s {Name} -1",
            $"execute as {TargetsHandler.Get(targets)} unless score @s {Name} > #{EnumMap[EnumMap.Count-1]} {Name} run scoreboard players add @s {Name} 1"
        ]);
    }
    public void Next(string targets) {
        FunctionBuilder.Add([
            $"execute as {targets} if score @s {Name} >= #{EnumMap[EnumMap.Count-1]} {Name} run scoreboard players set @s {Name} -1",
            $"execute as {targets} unless score @s {Name} > #{EnumMap[EnumMap.Count-1]} {Name} run scoreboard players add @s {Name} 1"
        ]);
    }
    public void Past(Targets targets) {
        FunctionBuilder.Add([
            $"execute as {TargetsHandler.Get(targets)} if score @s {Name} matches ..0 run scoreboard players set @s {Name} {Count-1}",
            $"execute as {TargetsHandler.Get(targets)} unless score @s {Name} matches ..1 run scoreboard players remove @s {Name} 1"
        ]);
    }
    public void Past(string targets) {
        FunctionBuilder.Add([
            $"execute as {targets} if score @s {Name} matches ..0 run scoreboard players set @s {Name} {Count-1}",
            $"execute as {targets} unless score @s {Name} matches ..1 run scoreboard players remove @s {Name} 1"
        ]);
    }
}