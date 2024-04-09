// Report.cs
using System;

public class Report
{
    // Member Variables
    private string content;

    // Constructor
    public Report(string content)
    {
        this.content = content;
    }

    // Properties
    public string Content
    {
        get { return content; }
    }
}