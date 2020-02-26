namespace Plaid.Net.Categories
{
    public class CategoriesResponse
    {
        public string CategoryId { get; set; }
        
        public string Group { get; set; }
        
        public string[] Hierarchy { get; set; }
    }
}