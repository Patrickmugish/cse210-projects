// Inventory.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private List<Product> products;
    private List<Sale> sales;

    public Inventory()
    {
        products = new List<Product>();
        sales = new List<Sale>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public Product GetProductById(int id)
    {
        foreach (Product product in products)
        {
            if (product.ID == id)
            {
                return product;
            }
        }
        return null; // Product not found
    }

    public void RecordSale(Sale sale)
    {
        sales.Add(sale);
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }

    public List<Sale> GetSales()
    {
        return sales;
    }

    public List<Product> GetPopularProducts()
    {
        // Get products with highest sales count
        int maxSalesCount = products.Max(p => p.SalesCount);
        return products.Where(p => p.SalesCount == maxSalesCount).ToList();
    }
}