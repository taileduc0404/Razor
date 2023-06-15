namespace Razor.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? Category { get; set; }
        public decimal? Price { get; set; }
    }
}
