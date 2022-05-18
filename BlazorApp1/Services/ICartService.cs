using Class_Library.Models;
using Class_Library.Models.Products;

namespace Blazor_WebAssembly.Services
{
    public interface ICartService
    {
        List<OrderItem> OrderedItems { get; }

        event CartService.Notify CartItemsChanged;

        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void CheckedOut();
        void NewCart();
    }
}