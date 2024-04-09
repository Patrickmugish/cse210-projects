using System;

class Program
{
    static void Main(string[] args)
    {
        // Create inventory
        Inventory inventory = new Inventory();

        // Create report generator
        ReportGenerator reportGenerator = new ReportGenerator(inventory);

        // Create user interface
        UserInterface userInterface = new UserInterface(inventory, reportGenerator);

        // Simulate interactions
        Console.WriteLine("Welcome to the Inventory Management System!");

        // Add new product
        Product newProduct = new Product("Smartphone", 1001, "Electronics", 499.99, 50);
        inventory.AddProduct(newProduct, 50);
        Console.WriteLine("Added new product: " + newProduct.Name);

        // Record sale
        int quantitySold = 10;
        userInterface.RecordSale(newProduct, quantitySold);
        Console.WriteLine("Recorded sale of " + quantitySold + " units of " + newProduct.Name);

        // Generate sales report
        Console.WriteLine("Generating sales report...");
        reportGenerator.GenerateSalesReport();

        // Generate inventory report
        Console.WriteLine("Generating inventory report...");
        reportGenerator.GenerateInventoryReport();

        // Generate popular products report
        Console.WriteLine("Generating popular products report...");
        reportGenerator.GeneratePopularProductsReport();

        Console.WriteLine("Exiting Inventory Management System. Goodbye!");
    }
}