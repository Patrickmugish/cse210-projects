using System;
using System.Collections.Generic;

public class Product
{
    // Member Variables
    public string Name { get; set; }
    public int ID { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }
    public List<Sale> SalesHistory { get; set; }

    // Constructor
    public Product(string name, int id, string category, double price, int quantity)
    {
        Name = name;
        ID = id;
        Category = category;
        Price = price;
        QuantityInStock = quantity;
        SalesHistory = new List<Sale>();
    }

    // Behaviors
    public void AddToInventory(int quantity)
    {
        QuantityInStock += quantity;
    }

    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    public void RecordSale(int quantitySold)
    {
        QuantityInStock -= quantitySold;
        SalesHistory.Add(new Sale(DateTime.Now, quantitySold));
    }
}