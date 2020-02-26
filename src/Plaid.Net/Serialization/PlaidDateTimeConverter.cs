using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plaid.Net.Serialization
{
    /// <summary>
    /// Reads and writes DateTime values in ISO-8601 format (YY-MM-DDDD)
    /// </summary>
    public class PlaidDateTimeConverter : JsonConverter<DateTime>
    {
        private const string Iso8601Format = "yyyy-MM-dd";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateTime.ParseExact(value, Iso8601Format, CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            var formatted = value.ToString(Iso8601Format, CultureInfo.InvariantCulture);
            writer.WriteStringValue(formatted);
        }
    }
}