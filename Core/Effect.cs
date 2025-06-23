using SteveSharp.Generic;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core;

public static class Effect {
    public static void Give(Targets targets, StatusEffect effect, bool infinite = false, int amplifier = 0) => FunctionBuilder.Add(Str.Effect.Give(targets, effect, infinite, amplifier));
    public static void Give(string targets, StatusEffect effect, bool infinite = false, int amplifier = 0) => FunctionBuilder.Add(Str.Effect.Give(targets, effect, infinite, amplifier));
    
    public static void Give(Targets targets, StatusEffect effect, int seconds, int amplifier = 0) => FunctionBuilder.Add(Str.Effect.Give(targets, effect, seconds, amplifier));
    public static void Give(string targets, StatusEffect effect, int seconds, int amplifier = 0) => FunctionBuilder.Add(Str.Effect.Give(targets, effect, seconds, amplifier));

    public static void Give(Targets targets, string effect, bool infinite = false, int amplifier = 0) => FunctionBuilder.Add(Str.Effect.Give(targets, effect, infinite, amplifier));
    public static void Give(string targets, string effect, bool infinite = false, int amplifier = 0) => FunctionBuilder.Add(Str.Effect.Give(targets, effect, infinite, amplifier));
    
    public static void Give(Targets targets, string effect, int seconds, int amplifier = 0) => FunctionBuilder.Add(Str.Effect.Give(targets, effect, seconds, amplifier));
    public static void Give(string targets, string effect, int seconds, int amplifier = 0) => FunctionBuilder.Add(Str.Effect.Give(targets, effect, seconds, amplifier));

    public static void Clear() => FunctionBuilder.Add(Str.Effect.Clear());
    
    public static void Clear(Targets targets) => FunctionBuilder.Add(Str.Effect.Clear(targets));
    public static void Clear(string targets) => FunctionBuilder.Add(Str.Effect.Clear(targets));

    public static void Clear(Targets targets, StatusEffect effect) => FunctionBuilder.Add(Str.Effect.Clear(targets, effect));
    public static void Clear(string targets, StatusEffect effect) => FunctionBuilder.Add(Str.Effect.Clear(targets, effect));

    public static void Clear(Targets targets, string effect) => FunctionBuilder.Add(Str.Effect.Clear(targets, effect));
    public static void Clear(string targets, string effect) => FunctionBuilder.Add(Str.Effect.Clear(targets, effect));
}