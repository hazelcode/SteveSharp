using SteveSharp.Generic;

namespace SteveSharp.Core.Strings;

public static class EnchantCommand {
    public static string Enchant(EntityTarget targets, Enchantment enchantment) => $"enchant {EntityTargetHandler.Get(targets)} {EnchantmentHandler.Get(enchantment)}";
    public static string Enchant(EntityTarget targets, Enchantment enchantment, int level) => $"enchant {EntityTargetHandler.Get(targets)} {EnchantmentHandler.Get(enchantment)} {level}";
    public static string Enchant(EntityTarget targets, string enchantment) => $"enchant {EntityTargetHandler.Get(targets)} {enchantment}";
    public static string Enchant(EntityTarget targets, string enchantment, int level) => $"enchant {EntityTargetHandler.Get(targets)} {enchantment} {level}";
    public static string Enchant(string targets, string enchantment) => $"enchant {targets} {enchantment}";
    public static string Enchant(string targets, string enchantment, int level) => $"enchant {targets} {enchantment} {level}";
    public static string Enchant(string targets, Enchantment enchantment) => $"enchant {targets} {EnchantmentHandler.Get(enchantment)}";
    public static string Enchant(string targets, Enchantment enchantment, int level) => $"enchant {targets} {EnchantmentHandler.Get(enchantment)} {level}";
}