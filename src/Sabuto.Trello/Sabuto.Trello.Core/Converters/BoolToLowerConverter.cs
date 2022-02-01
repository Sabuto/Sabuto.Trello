using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sabuto.Trello.Core.Converters;

/// <summary>

/// This converts a bool value (True or False) to a lowercase for trello (true or false) via the Newtonsoft JsonConverter 

/// </summary>

/// <seealso cref="JsonConverter"/>

public class BoolToLowerConverter : JsonConverter
{
    /// <summary>
    /// Converts the json if the value is a bool
    /// </summary>
    /// <param name="writer">The writer</param>
    /// <param name="value">The value</param>
    /// <param name="serializer">The serializer</param>
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        string? val = value.ToString();
        if (string.Equals("true", val, StringComparison.OrdinalIgnoreCase) ||
            string.Equals("false", val, StringComparison.OrdinalIgnoreCase))
            val = val?.ToLower();

        writer.WriteValue(val);
    }

    /// <summary>
    /// This would convert when deserializing but we dont want that, must be included because of abstract class
    /// </summary>
    /// <param name="reader">The reader</param>
    /// <param name="objectType">The object type</param>
    /// <param name="existingValue">The existing value</param>
    /// <param name="serializer">The serializer</param>
    /// <exception cref="NotImplementedException"></exception>
    /// <returns>The object</returns>
    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Sets the CanRead to false so we dont convert when deserializing
    /// </summary>
    public override bool CanRead => false;

    /// <summary>
    /// Describes whether this instance can convert
    /// </summary>
    /// <param name="objectType">The object type</param>
    /// <returns>The bool</returns>
    public override bool CanConvert(Type objectType)
    {
        return (typeof(string) == objectType);
    }
}