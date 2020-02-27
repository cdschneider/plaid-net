namespace Plaid.Net.Core.Error
{
    public class PlaidApiErrorResponse : BasePlaidResponse
    {
        public ErrorType ErrorType { get; set; }
        
        public ErrorCode ErrorCode { get; set; }
        
        public string ErrorMessage { get; set; }
        
        public string DisplayMessage { get; set; }
    }
}