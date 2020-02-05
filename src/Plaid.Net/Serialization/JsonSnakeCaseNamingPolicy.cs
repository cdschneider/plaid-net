using System.Text.Json;

namespace Plaid.Net.Serialization
{
    public sealed class JsonSnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return name;

            var result = string.Empty;
            var chars = name.ToCharArray();
            
            for (int i = 0; i < chars.Length; i++)
            {
                result += char.ToLowerInvariant(chars[i]);
                if (i + 1 < chars.Length && char.IsUpper(chars[i + 1]))
                {
                    result += "_";
                }
            }

            return result;
        }
    }
}