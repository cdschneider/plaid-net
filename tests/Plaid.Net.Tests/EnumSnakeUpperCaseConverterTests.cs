using System.Text.Json;
using System.Text.Json.Serialization;
using Plaid.Net.Serialization;
using Xunit;

namespace Plaid.Net.Tests
{
    public class EnumSnakeUpperCaseConverterTests
    {
        [Fact]
        public void Read()
        {
            var json = "{\"value\":\"OPTION_THREE\"}";
            var deserialized = JsonSerializer.Deserialize<ObjectWithEnum>(json, GetOptions());
            
            Assert.Equal(TestEnum.OptionThree, deserialized.Value);    
        }

        [Fact]
        public void Read_WhenEnumIsSingleWord()
        {
            var json = "{\"value\":\"OPTION\"}";
            var deserialized = JsonSerializer.Deserialize<ObjectWithEnum>(json, GetOptions());
            
            Assert.Equal(TestEnum.Option, deserialized.Value);
        }
        
        [Fact]
        public void Write()
        {
            var data = new ObjectWithEnum { Value = TestEnum.OptionOne };
            var serialized = JsonSerializer.Serialize(data, GetOptions());
            
            var expected = "{\"value\":\"OPTION_ONE\"}";
            Assert.Equal(expected, serialized);
        }
        
        [Fact]
        public void Write_WhenEnumIsSingleWord()
        {
            var data = new ObjectWithEnum { Value = TestEnum.Option };
            var serialized = JsonSerializer.Serialize(data, GetOptions());
            
            var expected = "{\"value\":\"OPTION\"}";
            Assert.Equal(expected, serialized);
        }
        
        public JsonSerializerOptions GetOptions()
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new EnumSnakeUpperCaseConverter<TestEnum>());

            return options;
        }

        class ObjectWithEnum
        {
            [JsonPropertyName("value")]
            public TestEnum Value { get; set; }
        }
        
        enum TestEnum
        {
            Option,
            OptionOne,
            OptionTwo,
            OptionThree
        }
    }
}