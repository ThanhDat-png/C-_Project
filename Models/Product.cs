namespace ChineseBrand.Models
{
    public class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Slug { get; set; }

        public string? Description { get; set; }

        public string? Unit { get; set; }

        public int Stock { get; set; }

        public decimal CostPrice { get; set; }

        public int ProfitPercent { get; set; }

        public string? Image { get; set; }

        public string Status { get; set; } = "selling";

        public DateTime CreatedAt { get; set; }
    }
}