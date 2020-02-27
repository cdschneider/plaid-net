using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plaid.Net.Serialization
{
    public class EnumSnakeUpperCaseConverter<T> : JsonConverter<T> where T : struct, Enum
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString().Replace("_", "");
            return Enum.Parse<T>(value, true);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var asString = value.ToString();
            var chars = asString.ToCharArray();
            
            for (int i = 0; i < chars.Length; i++)
            {
                if (i < chars.Length - 1 && char.IsUpper(chars[i+1]))
                {
                    asString = asString.Insert(i+1, "_");
                }   
            }

            writer.WriteStringValue(asString.ToUpperInvariant());
        }
    }
}