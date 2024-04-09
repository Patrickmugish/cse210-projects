using System;
using System.Collections.Generic;

public class Inventory
{
    // Member Variables
    public List<Product> Products { get; set; }

    // Constructor
    public Inventory()
    {
        Products = new List<Product>();
    }

    // Behaviors
    public void AddProduct(Product product, int initialQuantity)
    {
        Products.Add(product);
        product.AddToInventory(initialQuantity);
    }

    public void UpdateProduct(Product product)
    {
        // Implementation to update product details
    }

    public void AdjustInventory(Product product, int quantity)
    {
        // Implementation to adjust inventory levels
    }
}