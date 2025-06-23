using SteveSharp.NBT;

namespace SteveSharp.MCDatapacksConventions;

/// <summary>
/// 1. Official Conventions
/// </summary>
public static class OC
{
    public class CTCMember(string name, object value, NBTType type = NBTType.SingleValue) : NBTTag(name, value, type);
    public class Trait(string traitName, bool enabled = true) : NBTTag(traitName, enabled);

    /// <summary>
    /// Common Trait Convention
    /// </summary>
    public static NBTTag CTC(List<CTCMember> members) => new NBTTag("ctc", members, NBTType.Compound);

    public static CTCMember Traits(List<Trait> traits) => new CTCMember("traits", traits, NBTType.Compound);
    public static CTCMember Id(string id) => new CTCMember("id", id);
    public static CTCMember From(string namespacedId) => new CTCMember("from", namespacedId);
    
}