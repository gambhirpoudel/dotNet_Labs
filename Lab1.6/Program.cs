// Write a C# program to store N numbers in a one-dimensional array
// and calculate its average with the help of a method.

using System;

class Program
{
    // Main method where the program execution starts
    static void Main()
    {
        // Prompt the user to enter the number of elements (N)
        Console.WriteLine("Enter the number of elements (N):");

        // Read the user input and convert it to an integer
        int N = Convert.ToInt32(Console.ReadLine());

        // Check if N is a positive integer
        if (N <= 0)
        {
            Console.WriteLine("Please enter a positive integer for N.");
        }
        else
        {
            // Create an array to store N numbers
            double[] numbers = new double[N];

            // Prompt the user to enter N numbers and store them in the array
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculate and display the average using the Average method
            double average = CalculateAverage(numbers);
            Console.WriteLine($"The average of the entered numbers is: {average}");
        }
    }

    // Method to calculate the average of an array of numbers
    static double CalculateAverage(double[] arr)
    {
        double sum = 0;

        // Calculate the sum of all elements in the array
        foreach (var num in arr)
        {
            sum += num;
        }

        // Calculate the average
        double average = sum / arr.Length;

        return average;
    }
}
