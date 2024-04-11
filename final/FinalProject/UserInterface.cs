using System;

public class UserInterface
{
    private Inventory inventory;
    private ReportGenerator reportGenerator;

    public UserInterface(Inventory inventory, ReportGenerator reportGenerator)
    {
        this.inventory = inventory;
        this.reportGenerator = reportGenerator;
    }

    public void AddNewProduct()
    {
        Console.WriteLine("Adding a New Product");
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        Console.Write("Enter product ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter product category: ");
        string category = Console.ReadLine();
        Console.Write("Enter product price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Enter initial quantity in stock: ");
        int quantity = int.Parse(Console.ReadLine());

        Product newProduct = new Product(id, name, category, price, quantity);
        inventory.AddProduct(newProduct);
        Console.WriteLine("Product added successfully!");
    }

    public void RecordSale()
    {
        Console.WriteLine("Recording a Sale");
        Console.Write("Enter product ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter quantity sold: ");
        int quantitySold = int.Parse(Console.ReadLine());

        Product product = inventory.GetProductById(id);
        if (product != null)
        {
            product.RecordSale(quantitySold);
            Console.WriteLine("Sale recorded successfully!");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void GenerateReport(Employee employee)
{
    Console.WriteLine("Generating Reports");
    Console.WriteLine("1. Sales Report");
    Console.WriteLine("2. Inventory Report");
    Console.WriteLine("3. Popular Products Report");

    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            // Generate sales report with the specified employee
            reportGenerator.GenerateSalesReport(employee);
            break;
        case "2":
            // Generate inventory report
            reportGenerator.GenerateInventoryReport();
            break;
        case "3":
            // Generate popular products report
            reportGenerator.GeneratePopularProductsReport();
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
}