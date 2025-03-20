using SteveSharp.Internal;
using SteveSharp.JsonShapes;
using System.Text.Json;

namespace SteveSharp
{
    public class Project
    {
        private string _name { get; set; }

        private string _description { get; set; }
        private int _packFormat { get; set; }
        private string _namespace { get; set; }
        public Dictionary<string, Function> FunctionIndex { get; set; }
        private readonly Function _load;
        private readonly Function _main;
        private readonly List<Function> _functions;
        public Dictionary<string, string[]> FunctionContents = new();
        public Dictionary<string, object> Variables = new();

        private string[] GetFunctionCommands(string functionName) {
            return FunctionContents[functionName];
        }

        public Project(string name, string description, string id, PackFormat packFormat, Function load, Function main, List<Function> functions, List<List<Function>> matrix = null!, List<JsonFile> jsonFiles = null!)
        {
            // Display fresh SteveSharp Display
            Displays.SteveSharpDisplay(name);
            _name = name;
            _description = description;
            _namespace = id;
            _packFormat = (int)packFormat;
            _load = load;
            _main = main;
            _functions = functions;
            Context.PackFormat = packFormat;
            FunctionIndex = new Dictionary<string, Function>();
            string loadPath = FileOrganizer.GetFunctionPath(_load.Name);
            string mainPath = FileOrganizer.GetFunctionPath(_main.Name);
            Directory.CreateDirectory(name);
            Environment.CurrentDirectory = name;
            FileOrganizer.CreateFullDirectory($"data/{id}/functions");
            FileOrganizer.CreateFullDirectory($"data/minecraft/tags/functions");
            var metadata = new PackMetadata
            {
                pack = new Pack
                {
                    description = description,
                    pack_format = _packFormat
                }
            };
            File.WriteAllText("pack.mcmeta", JsonSerializer.Serialize(metadata, new JsonSerializerOptions { WriteIndented = true }));
            File.WriteAllText($"data/minecraft/tags/functions/load.json",
                JsonSerializer.Serialize(new Tag
                {
                    values = new string[] { _load.Name }
                }, new JsonSerializerOptions { WriteIndented = true })
            );
            File.WriteAllText($"data/minecraft/tags/functions/tick.json",
                JsonSerializer.Serialize(new Tag
                {
                    values = new string[] { _main.Name }
                }, new JsonSerializerOptions { WriteIndented = true })
            );
            Displays.ProjectCreated();
            FunctionBuilder.BuildFunction(_load, _namespace, _packFormat, this);
            File.WriteAllLines(loadPath, GetFunctionCommands(_load.Name));
            Displays.WrittenFunction(_load.Name);
            FunctionBuilder.BuildFunction(_main, _namespace, _packFormat, this);
            File.WriteAllLines(mainPath, GetFunctionCommands(_main.Name));
            Displays.WrittenFunction(_main.Name);

            if (_functions.Count > 0)
            {
                foreach (var function in functions)
                {
                    FunctionIndex.Add(function.Name, function);
                }
            }
            if (matrix != null && matrix.Count > 0)
            {
                foreach (var list in matrix)
                {
                    foreach (var fun in list)
                    {
                        FunctionIndex.Add(fun.Name, fun);
                    }
                }
            }
            if (FunctionIndex.Count > 0)
                foreach (var function in FunctionIndex)
                {
                    if (!File.Exists(FileOrganizer.GetFunctionPath(function.Value.Name)))
                    {
                        Displays.NewFunction(function.Value.Name);
                    }
                    else
                    {
                        Displays.WrittenFunction(function.Value.Name);
                    }

                    //Fix directory-related errors about directories not found
                    string directory = Path.GetDirectoryName(FileOrganizer.GetFunctionPath(function.Value.Name))!;
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    FunctionBuilder.BuildFunction(function.Value, _namespace, _packFormat, this);
                    File.WriteAllLines(FileOrganizer.GetFunctionPath(function.Value.Name), GetFunctionCommands(function.Value.Name));
                }

            if (jsonFiles != null && jsonFiles.Count > 0)
            {
                foreach (var file in jsonFiles)
                {
                    string directory = Path.GetDirectoryName(file.Path)!;
                    string jsonText = JsonSerializer.Serialize(file.Object, new JsonSerializerOptions { WriteIndented = true });
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    if(!File.Exists(file.Path)) {
                        Displays.NewJson(file.Path);
                    } else {
                        Displays.WrittenJson(file.Path);
                    }
                    File.WriteAllText(file.Path, jsonText);
                }
            }
        }
    }
}
