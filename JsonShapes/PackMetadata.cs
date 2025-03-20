using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes
{
    public class PackMetadata
    {
        [JsonPropertyName("pack")]
        public Pack? Pack { get; set; }
    }
    public class Pack
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("pack_format")]
        public PackFormat PackFormat { get; set; }

        /// <summary>
        /// Pack Format 18+ Feature.
        /// Values accepted by the pack metadata:
        /// SupportedFormats = <PackFormat>
        /// SupportedFormats = new PackFormat[] {<PackFormat>, <PackFormat>}
        /// SupportedFormats = new List<PackFormat> {<PackFormat>, <PackFormat>}
        /// SupportedFormats = new SupportedFormatsRange {
        ///     MinInclusive = <PackFormat>,
        ///     MaxInclusive = <PackFormat>
        /// }
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("supported_formats")]
        public dynamic? SupportedFormats { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("overlays")]
        public OverlaysField Overlays { get; set; }
    }

    public struct SupportedFormatsRange {
        [JsonPropertyName("min_inclusive")]
        public PackFormat MinInclusive { get; set; }

        [JsonPropertyName("max_inclusive")]
        public PackFormat MaxInclusive { get; set; }
    }

    public struct OverlaysField {
        [JsonPropertyName("entries")]
        public OverlayEntry[] Entries { get; set; }
    }

    public struct OverlayEntry {
        // Same as supported_formats
        [JsonPropertyName("formats")]
        public dynamic Formats { get; set; }

        [JsonPropertyName("directory")]
        public string Directory { get; set; }
    }
}
