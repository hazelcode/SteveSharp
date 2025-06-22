using SteveSharp.NBT;

namespace SteveSharp.Exceptions;
public class NBTParsingException(NBTTag nbt) : Exception {
    public NBTTag NBT { get => nbt; }
    public override string Message => $"Could not parse NBT Tag \"{NBT.Name}\". Please check the value type and tag type:\n\tValue Type: {NBT.Value.GetType()}\n\tTag Type: {NBT.Type}\nPlease check if it isn't supported by the NBT Tag parser.";
}