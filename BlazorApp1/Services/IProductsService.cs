using Class_Library.Models.Products;

namespace Blazor_WebAssembly.Services
{
    public interface IProductsService
    {
        List<Category> GetCategories();
        List<Product> GetProducts();
        List<Product> GetProductsByCategory(int id);
    }
}