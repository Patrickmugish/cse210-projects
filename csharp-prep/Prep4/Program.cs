using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber;
        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string userResponse = Console.ReadLine();

            if (!int.TryParse(userResponse, out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            numbers.Add(userNumber);

        } while (userNumber != 0);

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Sretch1 Part: Find the smallest positive number closest to zero
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number closest to zero is: {smallestPositive}");

        // Stretch2 Part: Sort the numbers
        numbers.Sort();
        Console.WriteLine("Sorted List:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }       
    }
}