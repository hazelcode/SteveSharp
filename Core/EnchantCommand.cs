using SteveSharp.Generic;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core;

public static class EnchantCommand {
    public static void Enchant(EntityTarget targets, Enchantment enchantment) => FunctionBuilder.Add(Str.EnchantCommand.Enchant(targets, enchantment));
    public static void Enchant(EntityTarget targets, Enchantment enchantment, int level) => FunctionBuilder.Add(Str.EnchantCommand.Enchant(targets, enchantment, level));
    public static void Enchant(EntityTarget targets, string enchantment) => FunctionBuilder.Add(Str.EnchantCommand.Enchant(targets, enchantment));
    public static void Enchant(EntityTarget targets, string enchantment, int level) => FunctionBuilder.Add(Str.EnchantCommand.Enchant(targets, enchantment, level));
    public static void Enchant(string targets, string enchantment) => FunctionBuilder.Add(Str.EnchantCommand.Enchant(targets, enchantment));
    public static void Enchant(string targets, string enchantment, int level) => FunctionBuilder.Add(Str.EnchantCommand.Enchant(targets, enchantment, level));
    public static void Enchant(string targets, Enchantment enchantment) => FunctionBuilder.Add(Str.EnchantCommand.Enchant(targets, enchantment));
    public static void Enchant(string targets, Enchantment enchantment, int level) => FunctionBuilder.Add(Str.EnchantCommand.Enchant(targets, enchantment, level));
}