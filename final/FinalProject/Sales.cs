using System;

public class Sale
{
    // Member Variables
    public DateTime Timestamp { get; set; }
    public int QuantitySold { get; set; }

    // Constructor
    public Sale(DateTime timestamp, int quantitySold)
    {
        Timestamp = timestamp;
        QuantitySold = quantitySold;
    }
}