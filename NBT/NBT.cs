namespace SteveSharp.NBT;

public class NBTTag
{
    public NBTType Type { get; }
    public string Name { get; set; }
    public object Value { get; set; }

    public NBTTag(string name, object value, NBTType type = NBTType.SingleValue)
    {
        Type = type;
        Name = name;
        Value = value;
    }
}