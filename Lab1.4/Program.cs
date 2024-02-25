// Write a program to evaluate GCD of two given integers. 
// Use a function that returns GCD.

using System;

class Program
{
    // Main method where the program execution starts
    static void Main()
    {
        // Prompt the user to enter two integers
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Calculate and display the GCD using the GCD function
        int gcd = CalculateGCD(num1, num2);

        Console.WriteLine($"The GCD of {num1} and {num2} is: {gcd}");
    }

    // Function to calculate the GCD using Euclidean algorithm
    static int CalculateGCD(int a, int b)
    {
        // Continue the loop until b becomes 0
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        // The GCD is the non-zero remainder, which is stored in 'a'
        return a;
    }
}
