using System.ComponentModel.DataAnnotations;

namespace Day3Work.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set;}
        public DateTime? CreatedDate { get; set; }
    }
}
