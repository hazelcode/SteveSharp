using SteveSharp.Exceptions;
using SteveSharp.Internal;

namespace SteveSharp.Generic;

// https://www.digminecraft.com/lists/effect_list_pc.php
internal static class StatusEffectHandler {
    internal static string Get(StatusEffect effect) {
        Dictionary<StatusEffect, string> statusEffectStr = new() {
            {StatusEffect.Absorption, "absorption"},
            {StatusEffect.BadLuck, "unluck"},
            {StatusEffect.BadOmen, "bad_omen"},
            {StatusEffect.Blindness, "blindness"},
            {StatusEffect.ConduitPower, "conduit_power"},
            {StatusEffect.Darkness, "darkness"},
            {StatusEffect.DolphinsGrace, "dolphins_grace"},
            {StatusEffect.FireResistance, "fire_resistance"},
            {StatusEffect.Glowing, "glowing"},
            {StatusEffect.Haste, "haste"},
            {StatusEffect.HealthBoost, "health_boost"},
            {StatusEffect.HeroOfTheVillage, "hero_of_the_village"},
            {StatusEffect.Hunger, "hunger"},
            {StatusEffect.Infested, "infested"},
            {StatusEffect.InstantDamage, "instant_damage"},
            {StatusEffect.InstantHealth, "instant_health"},
            {StatusEffect.Invisibility, "invisibility"},
            {StatusEffect.JumpBoost, "jump_boost"},
            {StatusEffect.Levitation, "levitation"},
            {StatusEffect.Luck, "luck"},
            {StatusEffect.MiningFatigue, "mining_fatigue"},
            {StatusEffect.Nausea, "nausea"},
            {StatusEffect.NightVision, "night_vision"},
            {StatusEffect.Oozing, "oozing"},
            {StatusEffect.Poison, "poison"},
            {StatusEffect.RaidOmen, "raid_omen"},
            {StatusEffect.Regeneration, "regeneration"},
            {StatusEffect.Resistance, "resistance"},
            {StatusEffect.Saturation, "saturation"},
            {StatusEffect.SlowFalling, "slow_falling"},
            {StatusEffect.Slowness, "slowness"},
            {StatusEffect.Speed, "speed"},
            {StatusEffect.Strength, "strength"},
            {StatusEffect.TrialOmen, "trial_omen"},
            {StatusEffect.WaterBreathing, "water_breathing"},
            {StatusEffect.Weakness, "weakness"},
            {StatusEffect.Weaving, "weaving"},
            {StatusEffect.WindCharged, "wind_charged"},
            {StatusEffect.Wither, "wither"}
        };
        return statusEffectStr[effect];
    }
}