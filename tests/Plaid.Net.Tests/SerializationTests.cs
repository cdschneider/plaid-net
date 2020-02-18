using System.Text.Json;
using Plaid.Net.Sandbox;
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
                var options = new JsonSerializerOptions { PropertyNamingPolicy = (JsonNamingPolicy) new JsonSnakeCaseNamingPolicy(), IgnoreNullValues = true, };
                var serialized = JsonSerializer.Serialize(new SandboxTokenCreateRequest
                {
                    InstitutionId = "ins_1234",
                    PublicKey = "pub-key-01234",
                    InitialProducts = new[] {"1234", "5678"}
                }, options);
                
                Assert.Equal(
                    "{\"institution_id\":\"ins_1234\",\"public_key\":\"pub-key-01234\",\"initial_products\":[\"1234\",\"5678\"]}", 
                    serialized);
            }

            [Fact]
            public void Serialize_SandboxTokenCreateOptions()
            {
                var options = new JsonSerializerOptions { PropertyNamingPolicy = (JsonNamingPolicy) new JsonSnakeCaseNamingPolicy(), IgnoreNullValues = true, };
                var serialized = JsonSerializer.Serialize(new SandboxTokenCreateOptions
                {
                    Webhook = "https://www.genericwebhookurl.com/webhook",
                    OverrideUsername = "test_user",
                    OverridePassword = "test_password"
                }, options);
                
                Assert.Equal(
                    "{\"webhook\":\"https://www.genericwebhookurl.com/webhook\",\"override_username\":\"test_user\",\"override_password\":\"test_password\"}", 
                    serialized);
            }
        }
    }
}