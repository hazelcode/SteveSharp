namespace SteveSharp.Core
{
    public static class XYZ
    {
        public static (int x, int y) Vec2(int x, int y) => (x, y);
        public static (string x, string y) Vec2(string x, string y) => (x, y);
        public static (int x, int y, int z) Vec3(int x, int y, int z) => (x, y, z);
        public static (string x, string y, string z) Vec3(string x, string y, string z) => (x, y, z);
        public static (string x, string y, string z) Rel(int x, int y, int z)
            => ('~' + (x == 0 ? "" : x.ToString()),
                '~' + (y == 0 ? "" : y.ToString()),
                '~' + (z == 0 ? "" : z.ToString()));
        public static string[] Pos(int a, int b, int c) {
            return ["^"+b, "^"+b, "^"+c];
        }
        public static string[] Pos(string a, string b, string c) {
            return ['^'+a, '^'+b, '^'+c];
        }
    }
}
