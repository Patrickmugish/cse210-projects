using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    // Properties
    public int ID { get; private set; }
    public string Name { get; private set; }
    public string Category { get; private set; }
    public double Price { get; private set; }
    public int QuantityInStock { get; private set; }
    public int SalesCount { get; private set; }

    // Constructor
    public Product(int id, string name, string category, double price, int quantityInStock)
    {
        ID = id;
        Name = name;
        Category = category;
        Price = price;
        QuantityInStock = quantityInStock;
        SalesCount = 0;
    }

    // Methods
    public void RecordSale(int quantitySold)
    {
        QuantityInStock -= quantitySold;
        SalesCount += quantitySold;
    }
}