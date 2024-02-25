/*Write a program to convert centigrade to Fahrenheit. [F = 9/5 * C + 32] (Do not change the expression) */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter temperature in Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit using the given formula
        double fahrenheit = (9.0 / 5.0) * celsius + 32;

        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
    }
}
