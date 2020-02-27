namespace Plaid.Net.Core.Error
{
    public enum ErrorType
    {
        InvalidRequest,
        
        InvalidInput,
        
        InstitutionError,
        
        RateLimitExceeded,
        
        ApiError,
        
        ItemError,
        
        AuthError,
        
        AssetReportError
    }
}