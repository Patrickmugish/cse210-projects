// Sale.cs
using System;

public class Sale
{
    public int ProductId { get; set; }
    public int QuantitySold { get; set; }
    public DateTime SaleDate { get; set; }
    public string ProductName { get; set; }

    public Sale(int productId, int quantitySold, string productName)
    {
        ProductId = productId;
        QuantitySold = quantitySold;
        SaleDate = DateTime.Now;
        ProductName = productName;
    }
}