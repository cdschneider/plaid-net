namespace Plaid.Net.Auth
{
    public class AuthGetRequest
    {
        public string AccessToken { get; set; }
        
        public string ClientId { get; set; }
        
        public string Secret { get; set; }
        
        public AuthGetRequestOptions Options { get; set; }
    }
    
    public class AuthGetRequestOptions
    {
        public string[] AccountIds { get; set; }
    }
}