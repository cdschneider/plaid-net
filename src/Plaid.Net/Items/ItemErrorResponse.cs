using Plaid.Net.Core.Error;

namespace Plaid.Net.Items
{
    public class ItemErrorResponse
    {
        public ErrorType ErrorType { get; set; }
        
        public ErrorCode ErrorCode { get; set; }
        
        public string ErrorMessage { get; set; }
        
        public string DisplayMessage { get; set; }
    }
}