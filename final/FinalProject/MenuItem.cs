// MenuItem.cs
using System;

public class MenuItem
{
    // Member Variables
    private string name;
    private Action action;

    // Constructor
    public MenuItem(string name, Action action)
    {
        this.name = name;
        this.action = action;
    }

    // Methods
    public void ExecuteAction()
    {
        action();
    }
}