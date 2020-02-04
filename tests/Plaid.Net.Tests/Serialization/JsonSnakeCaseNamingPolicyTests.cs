using Plaid.Net.Serialization;
using Xunit;

namespace Plaid.Net.Tests.Serialization
{
    public class JsonSnakeCaseNamingPolicyTests
    {
        [Theory]
        [InlineData("property_name")]
        [InlineData("longer_prop_name")]
        public void ConvertName_WhenPropertyIsAlreadySnakeCased_ThenUnchanged(string propertyName)
        {
            var policy = new JsonSnakeCaseNamingPolicy();
            var converted = policy.ConvertName(propertyName);
            
            Assert.Equal(propertyName, converted);
        }

        [Theory]
        [InlineData("Id", "id")]
        [InlineData("LongerId", "longer_id")]
        [InlineData("ReallyReallyReallyLongIdentifier", "really_really_really_long_identifier")]
        public void ConvertName_WhenPropertyIsPascalCased(string propertyName, string expected)
        {
            var policy = new JsonSnakeCaseNamingPolicy();
            var converted = policy.ConvertName(propertyName);
            
            Assert.Equal(expected, converted);
        }
    }
}