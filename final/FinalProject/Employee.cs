// Employee.cs
using System;

public class Employee
{
    // Member Variables
    private string name;
    private string role;

    // Constructor
    public Employee(string name, string role)
    {
        this.name = name;
        this.role = role;
    }

    // Properties
    public string Name
    {
        get { return name; }
    }

    public string Role
    {
        get { return role; }
    }
}