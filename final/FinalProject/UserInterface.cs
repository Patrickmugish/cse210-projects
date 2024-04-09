public class UserInterface
{
    // Member Variables
    private Inventory inventory;
    private ReportGenerator reportGenerator;

    // Constructor
    public UserInterface(Inventory inventory, ReportGenerator reportGenerator)
    {
        this.inventory = inventory;
        this.reportGenerator = reportGenerator;
    }

    // Behaviors
    public void AddNewProduct()
    {
        // Implementation to add a new product
    }

    public void RecordSale(Product product, int quantitySold)
    {
        inventory.UpdateProduct(product); // Update product details if necessary
        product.RecordSale(quantitySold);
    }

    public void GenerateReport()
    {
        // Implementation to generate a report
    }
}