using System.Text.Json;
using Plaid.Net.Serialization;
using Xunit;

namespace Plaid.Net.Tests
{
    public class SerializationTests
    {
        public class SandboxSerializationTests
        {
            [Fact]
            public void Serialize_SandboxTokenCreateRequest()
            {
                var options = new JsonSerializerOptions { PropertyNamingPolicy = (JsonNamingPolicy) new JsonSnakeCaseNamingPolicy() };
                var serialized = JsonSerializer.Serialize(new SandboxTokenCreateRequest
                {
                    InstitutionId = "ins_1234",
                    PublicKey = "pub-key-01234",
                    InitialProducts = new[] {"1234", "5678"}
                }, options);
                
                Assert.Equal(
                    "{\"institution_id\": \"ins_1234\", \"public_key\": \"pub-key-01234\", \"initial_products\": [\"1234\", \"5678\"]}", 
                    serialized);
            }
        }
    }
}