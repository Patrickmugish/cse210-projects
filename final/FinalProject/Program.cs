class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter their name and ID
        Console.Write("Enter your name: ");
        string employeeName = Console.ReadLine();
        Console.Write("Enter your employee ID: ");
        int employeeId = int.Parse(Console.ReadLine());

        // Create the Employee object
        Employee employee = new Employee(employeeName, employeeId);

        // Create inventory
        Inventory inventory = new Inventory();

        // Create report generator
        ReportGenerator reportGenerator = new ReportGenerator(inventory);

        // Create user interface
        UserInterface userInterface = new UserInterface(inventory, reportGenerator);

        // Display menu and handle user input
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("Welcome To The Inventory Management System");
            Console.WriteLine("1. Add New Product");
            Console.WriteLine("2. Record Sale");
            Console.WriteLine("3. Generate Reports");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    userInterface.AddNewProduct();
                    break;
                case "2":
                    userInterface.RecordSale();
                    break;
                case "3":
                    userInterface.GenerateReport(employee); // Pass employee as argument
                    break;
                case "4":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Exiting Inventory Management System. Goodbye!");
    }
}