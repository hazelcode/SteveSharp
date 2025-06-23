using System.Text.Json.Serialization;

namespace SteveSharp.JsonShapes
{
    public class TextComponent
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

        [JsonPropertyName("color")]
        public string? Color { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("italic")]
        public bool Italic { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("bold")]
        public bool Bold { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("underlined")]
        public bool Underlined { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("obfuscated")]
        public bool Obfuscated { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("strikethrough")]
        public bool Strikethrough { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("insertion")]
        public string? Insertion { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("clickEvent")]
        public ClickEvent? ClickEvent { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("extra")]
        public TextComponent[]? Extra { get; set; }
    }
    public class ClickEvent
    {
        [JsonPropertyName("action")]

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Action { get; set; }
        [JsonPropertyName("value")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Value { get; set; }
    }
}
