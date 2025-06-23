namespace SteveSharp.Exceptions;
public class StrictConventionException : Exception {
    public string Convention { get; set; }
    public string Reason { get; }
    public override string Message => $"MC Datapacks convention violation!\nConvention: {Convention}\nReason: \"{Reason}\".\nPlease check the convention and realize necessary changes.";
    public StrictConventionException(string convention, string reason) {
        Convention = convention;
        Reason = reason;
    }
}