using Str = SteveSharp.Core.Strings;

namespace SteveSharp.Core;

public static class For
{
    public static void Loop(int to, Func<int, List<String>> block, int from = 0) => FunctionBuilder.Add(Str.For.Loop(to, block, from));
    public static List<Function> Functions(int to, Func<int, Function> block, int from = 0) {
        List<Function> fullBlock = new();
        for(int i = from; i <= to; i++) {
            fullBlock.Add(block(i));
        }
        return fullBlock;
    }
}