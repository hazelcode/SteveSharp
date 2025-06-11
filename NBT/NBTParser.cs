namespace SteveSharp.NBT;

public class NBTParser
{
    public string ParseValueType(object value)
        => value switch
        {
            string => "\"" + value.ToString() + "\"",
            float => value.ToString() + "f",
            bool => value.ToString()!.ToLower(),
            byte => value.ToString() + "b",
            short => value.ToString() + "s",
            long => value.ToString() + "l",
            _ => value.ToString()!
        };
    public string Parse(NBTTag nbt)
    {
        string nbtString = "";
        switch (nbt.Type)
        {
            case NBTType.SingleValue:
                return nbt.Name + ": " + ParseValueType(nbt.Value);
            case NBTType.List:
                nbtString = nbt.Name + ": [";
                List<object>? list = nbt.Value as List<object>;
                for (int i = 0; i < list!.Count; i++)
                {
                    nbtString += ParseValueType(list[i]);
                    if (i < list.Count - 1)
                        nbtString += ", ";
                }
                return s;
            case NBTType.Compound:
                nbtString = nbt.Name + "{";
                Dictionary<string, object>? compound = nbt.Value as Dictionary<string, object>;
                foreach (var item in compound!)
                {
                    nbtString += nbt.Name + ": ";
                    nbtString += nbt.Value switch
                    {
                        _ => nbtString.ToString()
                    };
                }
        }
        return null!;
    }
}