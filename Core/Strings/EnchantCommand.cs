using SteveSharp.Generic;

namespace SteveSharp.Core.Strings;

public static class EnchantCommand {
    public static string Enchant(Targets targets, Enchantment enchantment) => $"enchant {TargetsHandler.Get(targets)} {EnchantmentHandler.Get(enchantment)}";
    public static string Enchant(Targets targets, Enchantment enchantment, int level) => $"enchant {TargetsHandler.Get(targets)} {EnchantmentHandler.Get(enchantment)} {level}";
    public static string Enchant(Targets targets, string enchantment) => $"enchant {TargetsHandler.Get(targets)} {enchantment}";
    public static string Enchant(Targets targets, string enchantment, int level) => $"enchant {TargetsHandler.Get(targets)} {enchantment} {level}";
    public static string Enchant(string targets, string enchantment) => $"enchant {targets} {enchantment}";
    public static string Enchant(string targets, string enchantment, int level) => $"enchant {targets} {enchantment} {level}";
    public static string Enchant(string targets, Enchantment enchantment) => $"enchant {targets} {EnchantmentHandler.Get(enchantment)}";
    public static string Enchant(string targets, Enchantment enchantment, int level) => $"enchant {targets} {EnchantmentHandler.Get(enchantment)} {level}";
}