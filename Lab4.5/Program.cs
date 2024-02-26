using System;

// Custom exception class
class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Simulating a situation that triggers the custom exception
            throw new MyCustomException("This is a custom exception!");
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Caught Custom Exception: {ex.Message}");
        }
    }
}
