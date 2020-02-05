using System.Text.Json;
using Plaid.Net.Serialization;
using Xunit;

namespace Plaid.Net.Tests
{
    public class DeserializationTests
    {
        public class SandboxDeserializationTests
        {
            [Fact]
            public void Deserialize_SandboxTokenCreateResponse()
            {
                var serialized = "{\"public_token\":\"public-sandbox-1234567\",\"request_id\":\"qwertyuiop\"}";
                var options = new JsonSerializerOptions { PropertyNamingPolicy = (JsonNamingPolicy) new JsonSnakeCaseNamingPolicy(), IgnoreNullValues = true, };
                
                var deserialized = JsonSerializer.Deserialize<SandboxTokenCreateResponse>(serialized, options);
                Assert.NotNull(deserialized);
                Assert.Equal("public-sandbox-1234567", deserialized.PublicToken);
                Assert.Equal("qwertyuiop", deserialized.RequestId);
            }
        }
    }
}