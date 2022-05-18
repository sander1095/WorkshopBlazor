using Class_Library.Models;
using Class_Library.Models.Products;

namespace Blazor_WebAssembly.Services
{
    public class CartService : ICartService
    {
        public List<OrderItem> OrderedItems { get; private set; } = new List<OrderItem>();

        public void AddProduct(Product product)
        {
            var item = OrderedItems.Find(x => x.Product.Id == product.Id);

            if (item is null) {
                item = new OrderItem { Product = product };
                OrderedItems.Add(item);
            }

            item.Amount++;

            CartItemsChanged?.Invoke();
        }

        public void RemoveProduct(Product product)
        {
            var item = OrderedItems.Find(x => x.Product.Id == product.Id);
            if (item is null)
                return;

            item.Amount = (item.Amount>0) ? --item.Amount : 0;

            if (item.Amount == 0)
                OrderedItems.Remove(item);

            CartItemsChanged?.Invoke();
        }

        public void CheckedOut()
        {
            NewCart();
        }

        public void NewCart()
        {
            OrderedItems.Clear();
        }

        public event Notify CartItemsChanged;
        public delegate void Notify();
    }
}
