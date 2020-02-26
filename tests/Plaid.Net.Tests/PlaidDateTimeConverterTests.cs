using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Plaid.Net.Serialization;
using Xunit;

namespace Plaid.Net.Tests
{
    public class PlaidDateTimeConverterTests
    {
        [Fact]
        public void Read_WhenValidDateTime()
        {
            var json = "{\"timestamp\":\"1999-01-01\"}";
            var deserialized = JsonSerializer.Deserialize<ObjectWithTimestamp>(json, GetOptions());
            
            var expected = new DateTime(1999, 1, 1);
            Assert.Equal(expected, deserialized.Timestamp);    
        }

        [Theory]
        [InlineData("foobar")]
        [InlineData("01-01-1999")]
        [InlineData("1999-01-01T00:00:00.000")]
        public void Read_WhenNonValidDateTime(string value)
        {
            var json = "{\"timestamp\":\"" + value + "\"}";
            Assert.Throws<FormatException>(
                () => JsonSerializer.Deserialize<ObjectWithTimestamp>(json, GetOptions()));
        }

        [Fact]
        public void Write()
        {
            var data = new ObjectWithTimestamp { Timestamp = new DateTime(1999, 1, 1) };
            var serialized = JsonSerializer.Serialize(data, GetOptions());
            
            var expected = "{\"timestamp\":\"1999-01-01\"}";
            Assert.Equal(expected, serialized);
        }

        public JsonSerializerOptions GetOptions()
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new PlaidDateTimeConverter());

            return options;
        }
        
        class ObjectWithTimestamp
        {
            [JsonPropertyName("timestamp")]
            public DateTime Timestamp { get; set; }
        }
    }
}