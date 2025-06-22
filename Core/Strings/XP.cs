using SteveSharp.Generic;

namespace SteveSharp.Core.Strings;

public static class XP
{
    public static string AddXP(Targets targets, int amount)
    {
        return $"xp add {TargetsHandler.Get(targets)} {amount}";
    }

    public static string AddXP(string targets, int amount)
    {
        return $"xp add {targets} {amount}";
    }

    public static string AddXPLevels(Targets targets, int amount)
    {
        return $"xp add {TargetsHandler.Get(targets)} {amount} levels";
    }

    public static string AddXPLevels(string targets, int amount)
    {
        return $"xp add {targets} {amount} levels";
    }

    public static string AddXPPoints(Targets targets, int amount)
    {
        return $"xp add {TargetsHandler.Get(targets)} {amount} points";
    }

    public static string AddXPPoints(string targets, int amount)
    {
        return $"xp add {targets} {amount} points";
    }

    public static string XPLevelsQuery(Targets targets)
    {
        return $"xp query {TargetsHandler.Get(targets)} levels";
    }

    public static string XPLevelsQuery(string targets)
    {
        return $"xp query {targets} levels";
    }

    public static string XPQuery(Targets targets)
    {
        return $"xp query {TargetsHandler.Get(targets)} points";
    }

    public static string XPQuery(string targets)
    {
        return $"xp query {targets} points";
    }

    public static string SetXP(Targets targets, int amount)
    {
        return $"xp set {TargetsHandler.Get(targets)} {amount}";
    }

    public static string SetXP(string targets, int amount)
    {
        return $"xp set {targets} {amount}";
    }

    public static string SetXPLevels(Targets targets, int amount)
    {
        return $"xp set {TargetsHandler.Get(targets)} {amount} levels";
    }

    public static string SetXPLevels(string targets, int amount)
    {
        return $"xp set {targets} {amount} levels";
    }

    public static string SetXPPoints(Targets targets, int amount)
    {
        return $"xp set {TargetsHandler.Get(targets)} {amount} points";
    }

    public static string SetXPPoints(string targets, int amount)
    {
        return $"xp set {targets} {amount} points";
    }
}