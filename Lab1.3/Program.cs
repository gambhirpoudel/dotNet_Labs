/*Write a program to identify whether the given number is a perfect number or not. [28 is a perfect number.]*/
using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number:");

        // Read the number from user input
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is a perfect number
        if (IsPerfectNumber(number))
        {
            Console.WriteLine($"{number} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect number.");
        }
    }

    // Function to check if a number is a perfect number
    static bool IsPerfectNumber(int num)
    {
        int sum = 0;

        // Find the proper divisors and sum them up
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        // Check if the sum of proper divisors equals the original number
        return sum == num;
    }
}
