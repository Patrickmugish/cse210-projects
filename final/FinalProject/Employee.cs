// Employee.cs
public class Employee
{
    public string Name { get; private set; }
    public int EmployeeID { get; private set; }

    public Employee(string name, int employeeID)
    {
        Name = name;
        EmployeeID = employeeID;
    }
}