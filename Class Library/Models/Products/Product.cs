﻿namespace Class_Library.Models.Products;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string MarketingName { get; set; }
    public int CategoryId { get; set; }
    public decimal Price { get; set; }

    public Category Category { get; set; }
}