﻿namespace SteveSharp
{
    public static class FileOrganizer
    {
        public static string CreateFullDirectory(string Dir, bool createFile = false)
        {
            try
            {
                char[] separator = { '/', '\\' };
                string[] pathParts = Dir.Split(separator);
                int i;
                string path = "";
                for (i = 0; i < pathParts.Length; i++)
                {
                    if (i == 0) { path = pathParts[i]; }
                    else
                    {
                        path = path + "/" + pathParts[i];
                    }
                    if (i == pathParts.Length - 1 && createFile == true)
                    {
                        path = path.Replace("/" + pathParts[i], null);
                    }
                    Directory.CreateDirectory(path);
                }
                if (createFile == true)
                {
                    File.Create(Dir);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            return Dir;
        }
        public static string GetFunctionPath(string namespacedPath)
        {
            char[] separators = { ':', '/' };
            string[] parts = namespacedPath.Split(separators);
            string relativePath = "data/" + parts[0] + "/functions";
            for (int i = 1; i < parts.Length; i++)
            {
                relativePath = relativePath + "/" + parts[i];
            }
            relativePath = relativePath + ".mcfunction";
            return relativePath;
        }
        public static string GetJsonPath(string namespacedPath, string sector)
        {
            char[] separators = { ':', '/' };
            string[] parts = namespacedPath.Split(separators);
            string relativePath = "data/" + parts[0] + $"/{sector}";
            for (int i = 1; i < parts.Length; i++)
            {
                relativePath = relativePath + "/" + parts[i];
            }
            relativePath = relativePath + ".json";
            return relativePath;
        }
        public static string GetAsNamespacedPath(string id, string path, string sector)
        {
            string path2 = path.Replace(sector, "");
            string[] parts = path2.Split('/'); // data/functions/load.mcfunction => {"data", "functions", "load.mcfunction" }
            parts[parts.Length - 1] = parts[parts.Length - 1].Replace(".json", "");
            parts[parts.Length - 1] = parts[parts.Length - 1].Replace(".mcfunction", ""); // {"data", "functions", "load.mcfunction" } => {"data", "functions", "load" }
            parts = parts[1..];
            return id + ":" + string.Join('/', parts);
        }
        public static string GetFunctionName(string namespacedPath){
            string[] parts = namespacedPath.Split(new char[]{':','/'});
            return parts[parts.Length - 1];
        }
        public static string GetNamespace(string namespacedPath){
            string[] parts = namespacedPath.Split(new char[]{':','/'});
            return parts[0];
        }
    }
}
