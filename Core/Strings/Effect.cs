using SteveSharp.Generic;

namespace SteveSharp.Core.Strings;

public static class Effect {
    public static string Give(Targets targets, StatusEffect effect, bool infinite = false, int amplifier = 0) {
        if(infinite) {
            return $"effect give {TargetsHandler.Get(targets)} {StatusEffectHandler.Get(effect)} infinite {amplifier}";
        } else {
            return $"effect give {TargetsHandler.Get(targets)} {StatusEffectHandler.Get(effect)}";
        }
    }
    public static string Give(string targets, StatusEffect effect, bool infinite = false, int amplifier = 0) {
        if(infinite) {
            return $"effect give {targets} {StatusEffectHandler.Get(effect)} infinite {amplifier}";
        } else {
            return $"effect give {targets} {StatusEffectHandler.Get(effect)}";
        }
    }
    public static string Give(Targets targets, StatusEffect effect, int seconds, int amplifier = 0) {
        return $"effect give {TargetsHandler.Get(targets)} {StatusEffectHandler.Get(effect)} {seconds} {amplifier}";
    }
    public static string Give(string targets, StatusEffect effect, int seconds, int amplifier = 0) {
        return $"effect give {targets} {StatusEffectHandler.Get(effect)} {seconds} {amplifier}";
    }
    public static string Give(Targets targets, string effect, bool infinite = false, int amplifier = 0) {
        if(infinite) {
            return $"effect give {TargetsHandler.Get(targets)} {effect} infinite {amplifier}";
        } else {
            return $"effect give {TargetsHandler.Get(targets)} {effect}";
        }
    }
    public static string Give(string targets, string effect, bool infinite = false, int amplifier = 0) {
        if(infinite) {
            return $"effect give {targets} {effect} infinite {amplifier}";
        } else {
            return $"effect give {targets} {effect}";
        }
    }
    public static string Give(Targets targets, string effect, int seconds, int amplifier = 0) {
        return $"effect give {TargetsHandler.Get(targets)} {effect} {seconds} {amplifier}";
    }
    public static string Give(string targets, string effect, int seconds, int amplifier = 0) {
        return $"effect give {targets} {effect} {seconds} {amplifier}";
    }
    public static string Clear() {
        return "effect clear";
    }
    public static string Clear(Targets targets) {
        return $"effect clear {TargetsHandler.Get(targets)}";
    }
    public static string Clear(string targets) {
        return $"effect clear {targets}";
    }
    public static string Clear(Targets targets, StatusEffect effect) {
        return $"effect clear {TargetsHandler.Get(targets)} {StatusEffectHandler.Get(effect)}";
    }
    public static string Clear(string targets, StatusEffect effect) {
        return $"effect clear {targets} {StatusEffectHandler.Get(effect)}";
    }
    public static string Clear(Targets targets, string effect) {
        return $"effect clear {TargetsHandler.Get(targets)} {effect}";
    }
    public static string Clear(string targets, string effect) {
        return $"effect clear {targets} {effect}";
    }
}