using System;

// Declare a delegate
delegate void MyDelegate(string message);

class Program
{
    static void Main()
    {
        // Instantiate the delegate with a method
        MyDelegate myDelegate = new MyDelegate(DisplayMessage);

        // Call the delegate
        myDelegate("Hello from Delegate!");

        // Using a different method with the same delegate
        myDelegate = new MyDelegate(DisplayUpperCaseMessage);
        myDelegate("Delegate with uppercase message!");
    }

    static void DisplayMessage(string message)
    {
        Console.WriteLine($"Original Message: {message}");
    }

    static void DisplayUpperCaseMessage(string message)
    {
        Console.WriteLine($"Uppercase Message: {message.ToUpper()}");
    }
}
