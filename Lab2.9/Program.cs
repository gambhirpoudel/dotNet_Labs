// Question: Demonstration the use of Enum.

// Define an Enum
public enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

// Main program to demonstrate the use of Enum
class Program
{
    static void Main()
    {
        // Use Enum values
        Days today = Days.Wednesday;

        Console.WriteLine($"Today is: {today}");
    }
}
