using System.ComponentModel.DataAnnotations;

namespace OrderServiceAppAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
    }
}