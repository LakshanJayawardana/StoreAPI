using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace StoreAPI.Models
{
    public class ProductDetail
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }

        public int Price { get; set; }

        public bool IsAvailable { get; set; }

        

        

    }
}
