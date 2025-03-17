namespace SteveSharp;

public class FunctionContext {
    public FunctionContext(string functionName, string id, string functionPath, int packFormat, Project projectReference) {
        FunctionName = functionName;
        Namespace = id;
        FunctionPath = functionPath;
        PackFormat = packFormat;
        _projectReference = projectReference;
    }
    public string FunctionName { get; set; }
    public string Namespace { get; set; }
    public string FunctionPath { get; set; }
    public int PackFormat { get; set; }
    private Project _projectReference { get; set; }
    public Dictionary<string, object> Variables {
        get {
            return _projectReference.Variables;
        }
        set {}
    }
}