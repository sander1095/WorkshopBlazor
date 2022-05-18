using Class_Library.Models.Products;

namespace Class_Library.Models;

public class OrderItem
{
    public Product Product { get; set; }
    public int Amount { get; set; }
}