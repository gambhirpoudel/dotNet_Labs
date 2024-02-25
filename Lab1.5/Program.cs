// Write a recursive program to find the sum of n natural numbers.

using System;

class Program
{
    // Main method where the program execution starts
    static void Main()
    {
        // Prompt the user to enter a positive integer
        Console.WriteLine("Enter a positive integer:");

        // Read the user input and convert it to an integer
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the entered integer is positive
        if (n < 1)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            // Calculate and display the sum using the recursive function
            int sum = CalculateSum(n);
            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
        }
    }

    // Recursive function to calculate the sum of the first n natural numbers
    static int CalculateSum(int n)
    {
        // Base case: sum of first 1 natural number is 1
        if (n == 1)
        {
            return 1;
        }
        // Recursive case: sum of first n natural numbers is n + sum of first (n-1) natural numbers
        else
        {
            return n + CalculateSum(n - 1);
        }
    }
}
