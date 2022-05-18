using Class_Library.Models.Products;

namespace Class_Library.Context;

public class ProductsContext : IProductsContext
{
    private List<Product> _products { get; }
    private List<Category> _productcategories { get; }

    public ProductsContext()
    {
        _productcategories = new List<Category>() {
            new Category{Id = 1, Name = "Broodjes"}
            ,new Category{Id = 2, Name = "Drankjes"}
            ,new Category{Id = 3, Name = "Sides"}
        };
        _products = new List<Product>() {
             new Product { Id = 1, Category = _productcategories[0], Name = "Broodje gezond", MarketingName="broodjegezond", Price = 4.5M}
            ,new Product { Id = 2, Category = _productcategories[0], Name = "Broodje hete kip", MarketingName="broodjehetekip", Price = 5.5M}
            ,new Product { Id = 3, Category = _productcategories[0], Name = "Broodje bal", MarketingName="broodjebal", Price = 4.5M}
            ,new Product { Id = 4, Category = _productcategories[0], Name = "Broodje beenham", MarketingName="broodjebeenham", Price = 5.0M}
            ,new Product { Id = 5, Category = _productcategories[0], Name = "Tosti", MarketingName="tosti", Price = 3.12M}
            ,new Product { Id = 6, Category = _productcategories[1], Name = "Fles water", MarketingName="water", Price = 2.3M}
            ,new Product { Id = 7, Category = _productcategories[1], Name = "Blik frisdrank", MarketingName="frisdrank", Price = 3.25M}
            ,new Product { Id = 8, Category = _productcategories[1], Name = "Koffie", MarketingName="koffie", Price = 2M}
            ,new Product { Id = 9, Category = _productcategories[1], Name = "Cappuccino", MarketingName="cappuccino", Price = 2M}
            ,new Product { Id = 10, Category = _productcategories[2], Name = "Choco cookie", MarketingName="chocoladekoekje", Price = 1.95M}
            ,new Product { Id = 11, Category = _productcategories[2], Name = "Bosbessen muffin", MarketingName="bosbessenmuffin", Price = 2.45M}
            ,new Product { Id = 12, Category = _productcategories[2], Name = "Choco muffin", MarketingName="chocolademuffin",Price = 2.45M}
        };
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public List<Product> GetProductsByCategory(int categoryId)
    {
        return _products.Where(x => x.Category.Id == categoryId).ToList();
    }

    public Product GetProduct(int id)
    {
        return _products.SingleOrDefault(x => x.Id == id);
    }

    public List<Category> GetCategories()
    {
        return _productcategories;
    }
}