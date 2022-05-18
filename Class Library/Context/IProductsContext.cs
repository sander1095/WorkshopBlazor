using Class_Library.Models.Products;

namespace Class_Library.Context
{
    public interface IProductsContext
    {
        List<Category> GetCategories();
        Product GetProduct(int id);
        List<Product> GetProducts();
        List<Product> GetProductsByCategory(int categoryId);
    }
}