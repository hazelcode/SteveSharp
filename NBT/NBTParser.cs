using SteveSharp.Exceptions;

namespace SteveSharp.NBT;

public class NBTParser
{
    public string Encompass(string nbtText) => '{' + nbtText + '}';
    public string Encompass(List<string> nbtTexts)
    {
        string s = "{";
        for (int i = 0; i < nbtTexts.Count; i++)
        {
            s += nbtTexts[i];
            if (i < nbtTexts.Count - 1) // if it's not the last item in the list
                s += ", ";
        }
        s += "}";
        return s;
    }
    public string Enlist(string nbts) => '[' + nbts + ']';
    public string Enlist(List<string> nbts)
    {
        string s = "[";
        for (int i = 0; i < nbts.Count; i++)
        {
            s += nbts[i];
            if (i < nbts.Count - 1) // if it's not the last item in the list
                s += ", ";
        }
        s += "]";
        return s;
    }
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
        string nbtString = nbt.Name + ": ";
        switch (nbt.Type)
        {
            case NBTType.SingleValue:
                nbtString += ParseValueType(nbt.Value);
                return nbtString;
            case NBTType.List:
                dynamic? list;
                nbtString += "[";
                if (nbt.Value is List<int>)
                {
                    list = nbt.Value as List<int>;
                }
                else if (nbt.Value is List<double>)
                {
                    list = nbt.Value as List<double>;
                }
                else if (nbt.Value is List<float>)
                {
                    list = nbt.Value as List<float>;
                }
                else if (nbt.Value is List<byte>)
                {
                    list = nbt.Value as List<byte>;
                }
                else if (nbt.Value is List<short>)
                {
                    list = nbt.Value as List<short>;
                }
                else if (nbt.Value is List<long>)
                {
                    list = nbt.Value as List<long>;
                }
                else if (nbt.Value is List<char>)
                {
                    list = nbt.Value as List<char>;
                }
                else if (nbt.Value is List<string>)
                {
                    list = nbt.Value as List<string>;
                }
                else
                {
                    list = nbt.Value as List<object>;
                }

                for (int i = 0; i < list!.Count; i++)
                {
                    nbtString += ParseValueType(list[i]);
                    if (i < list.Count - 1) // if it's not the last item in the list
                        nbtString += ", ";
                }
                nbtString += "]";
                return nbtString;
            case NBTType.Compound:
                nbtString += "{";
                List<NBTTag>? tags = nbt.Value as List<NBTTag>;
                int left = tags!.Count;
                for (int i = 0; i < tags.Count; i++)
                {
                    nbtString += Parse(tags[i]);
                    if (i < tags.Count - 1) // if it's not the last item in the list
                        nbtString += ", ";
                }
                nbtString += "}";
                return nbtString;
            default:
                throw new NBTParsingException(nbt);
        }
    }
}