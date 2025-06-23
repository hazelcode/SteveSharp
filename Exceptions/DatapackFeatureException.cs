namespace SteveSharp.Exceptions;

public class DatapackFeatureException : Exception {
    public object Feature { get; }
    public PackFormat PackFormat { get; }
    public override string Message => $"The feature \"{Feature}\" isn't allowed to be used. You must update your project's pack format to {(int)PackFormat} to use this feature.";
    public DatapackFeatureException(object feature, PackFormat packFormat) {
        Feature = feature;
        PackFormat = packFormat;
    }
}