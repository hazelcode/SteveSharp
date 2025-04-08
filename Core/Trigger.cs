using SteveSharp.Generic;

namespace SteveSharp.Core;

public class Trigger : Score {
    public string Name { get; set; } = "trigger_"+new Random().Next(1,64);
    public string Targets { get; set; } = "@a";
    public Function OnTriggerFn { get; set; }

    public Trigger(string name, Targets targets, Function onTrigger) : base(name, "trigger") {
        Name = name;
        Targets = TargetsHandler.Get(targets);
        OnTriggerFn = onTrigger;
    }
    public Trigger(string name, string targets, Function onTrigger) : base(name, "trigger") {
        Name = name;
        Targets = targets;
        OnTriggerFn = onTrigger;
    }

    public void Enable() {
        FunctionBuilder.Add($"scoreboard players enable {Targets} {Name}");
    }

    public void IfTriggered(Targets targets, string matches) {
        FunctionBuilder.Add($"execute as {TargetsHandler.Get(targets)} if score @s {Name} matches {matches} run function {OnTriggerFn.Name}");
    }
    public void IfTriggered(string targets, string matches) {
        FunctionBuilder.Add($"execute as {targets} if score @s {Name} matches {matches} run function {OnTriggerFn.Name}");
    }
}