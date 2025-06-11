namespace SteveSharp.NBT;

public class NBTTag
{
    public NBTType Type { get; set; } = NBTType.SingleValue;
    public string Name { get; set; }
    public object Value { get; set; }

    public NBTTag(string name, object value)
    {
        Name = name;
        Value = value;
    }
}