using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep2 Activity");
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 97)
        {
            letter = "A+";
        }
        else if (percent >= 93)
        {
            letter = "A";
        }
        else if (percent <= 93)
        {
            letter = "A-";
        }
        if (percent >= 87)
        {
            letter = "B+";
        }
        else if (percent >= 83)
        {
            letter = "B";
        }
        else if (percent <= 83)
        {
            letter = "B-";
        }
        if (percent >= 77)
        {
            letter = "C+";
        }
        else if (percent >= 73)
        {
            letter = "C";
        }
         else if (percent <= 73)
        {
            letter = "C-";
        }
        if (percent >= 67)
        {
            letter = "D+";
        }
        else if (percent >= 63)
        {
            letter = "D";
        }
        else if (percent <= 63)
        {
            letter = "D-";
        }
        if (percent >= 57)
        {
            letter = "F+";
        }
        else if (percent >= 53)
        {
            letter = "F";
        }
        else if (percent <= 53)
        {
            letter = "F-";
        }
        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}