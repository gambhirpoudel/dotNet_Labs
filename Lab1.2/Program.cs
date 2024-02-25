/*Write a program to read the mark of a subject and print the equivalent grade. 
*/
using System;
class Program
{
    static void Main()
    {
        // Prompt the user to enter the mark for a subject
        Console.WriteLine("Enter the mark for the subject:");

        // Read the mark from the user input
        int mark = Convert.ToInt32(Console.ReadLine());

        // Determine the equivalent grade based on the mark
        char grade;

        if (mark >= 90)
        {
            grade = 'A';
        }
        else if (mark >= 80)
        {
            grade = 'B';
        }
        else if (mark >= 70)
        {
            grade = 'C';
        }
        else if (mark >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        // Print the equivalent grade
        Console.WriteLine($"Equivalent Grade: {grade}");
    }
}
