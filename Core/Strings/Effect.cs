using SteveSharp.Generic;

namespace SteveSharp.Core.Strings;

public static class Effect {
    public static string Give(EntityTarget targets, StatusEffect effect, bool infinite = false, int amplifier = 0) {
        if(infinite) {
            return $"effect give {EntityTargetHandler.Get(targets)} {StatusEffectHandler.Get(effect)} infinite {amplifier}";
        } else {
            return $"effect give {EntityTargetHandler.Get(targets)} {StatusEffectHandler.Get(effect)}";
        }
    }
    public static string Give(string targets, StatusEffect effect, bool infinite = false, int amplifier = 0) {
        if(infinite) {
            return $"effect give {targets} {StatusEffectHandler.Get(effect)} infinite {amplifier}";
        } else {
            return $"effect give {targets} {StatusEffectHandler.Get(effect)}";
        }
    }
    public static string Give(EntityTarget targets, StatusEffect effect, int seconds, int amplifier = 0) {
        return $"effect give {EntityTargetHandler.Get(targets)} {StatusEffectHandler.Get(effect)} {seconds} {amplifier}";
    }
    public static string Give(string targets, StatusEffect effect, int seconds, int amplifier = 0) {
        return $"effect give {targets} {StatusEffectHandler.Get(effect)} {seconds} {amplifier}";
    }
    public static string Give(EntityTarget targets, string effect, bool infinite = false, int amplifier = 0) {
        if(infinite) {
            return $"effect give {EntityTargetHandler.Get(targets)} {effect} infinite {amplifier}";
        } else {
            return $"effect give {EntityTargetHandler.Get(targets)} {effect}";
        }
    }
    public static string Give(string targets, string effect, bool infinite = false, int amplifier = 0) {
        if(infinite) {
            return $"effect give {targets} {effect} infinite {amplifier}";
        } else {
            return $"effect give {targets} {effect}";
        }
    }
    public static string Give(EntityTarget targets, string effect, int seconds, int amplifier = 0) {
        return $"effect give {EntityTargetHandler.Get(targets)} {effect} {seconds} {amplifier}";
    }
    public static string Give(string targets, string effect, int seconds, int amplifier = 0) {
        return $"effect give {targets} {effect} {seconds} {amplifier}";
    }
    public static string Clear() {
        return "effect clear";
    }
    public static string Clear(EntityTarget targets) {
        return $"effect clear {EntityTargetHandler.Get(targets)}";
    }
    public static string Clear(string targets) {
        return $"effect clear {targets}";
    }
    public static string Clear(EntityTarget targets, StatusEffect effect) {
        return $"effect clear {EntityTargetHandler.Get(targets)} {StatusEffectHandler.Get(effect)}";
    }
    public static string Clear(string targets, StatusEffect effect) {
        return $"effect clear {targets} {StatusEffectHandler.Get(effect)}";
    }
    public static string Clear(EntityTarget targets, string effect) {
        return $"effect clear {EntityTargetHandler.Get(targets)} {effect}";
    }
    public static string Clear(string targets, string effect) {
        return $"effect clear {targets} {effect}";
    }
}