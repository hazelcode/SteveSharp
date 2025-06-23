using SteveSharp.Generic;
using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core;

public static class XP
{
    #region Add
    public static void AddXP(Targets targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.AddXP(targets, amount));
    }

    public static void AddXP(string targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.AddXP(targets, amount));
    }

    public static void AddXPLevels(Targets targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.AddXPLevels(targets, amount));
    }

    public static void AddXPLevels(string targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.AddXPLevels(targets, amount));
    }

    public static void AddXPPoints(Targets targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.AddXPPoints(targets, amount));
    }

    public static void AddXPPoints(string targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.AddXPPoints(targets, amount));
    }
    #endregion
    #region Query
    public static void XPLevelsQuery(Targets targets)
    {
        FunctionBuilder.Add(Str.XP.XPLevelsQuery(targets));
    }

    public static void XPLevelsQuery(string targets)
    {
        FunctionBuilder.Add(Str.XP.XPLevelsQuery(targets));
    }

    public static void XPQuery(Targets targets)
    {
        FunctionBuilder.Add(Str.XP.XPQuery(targets));
    }

    public static void XPQuery(string targets)
    {
        FunctionBuilder.Add(Str.XP.XPQuery(targets));
    }
    #endregion
    #region Set
    public static void SetXP(Targets targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.SetXP(targets, amount));
    }

    public static void SetXP(string targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.SetXP(targets, amount));
    }

    public static void SetXPLevels(Targets targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.SetXPLevels(targets, amount));
    }

    public static void SetXPLevels(string targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.SetXPLevels(targets, amount));
    }

    public static void SetXPPoints(Targets targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.SetXPPoints(targets, amount));
    }

    public static void SetXPPoints(string targets, int amount)
    {
        FunctionBuilder.Add(Str.XP.SetXPPoints(targets, amount));
    }
    #endregion
}