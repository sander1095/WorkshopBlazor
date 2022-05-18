using Class_Library.Models.Products;
using System.Net.Http.Json;
using Class_Library.Context;

namespace Blazor_WebAssembly.Services;

public class ProductsService : IProductsService
{
    private readonly IProductsContext productsContext;

    public ProductsService(IProductsContext productsContext)
    {
        this.productsContext=productsContext;
    }

    public List<Product> GetProducts()
    {
        return productsContext.GetProducts();
    }

    public List<Product> GetProductsByCategory(int categoryId)
    {
        return productsContext.GetProductsByCategory(categoryId);
    }

    public List<Category> GetCategories()
    {
        return productsContext.GetCategories();
    }
}