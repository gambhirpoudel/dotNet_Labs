using System;

class Program
{
    static void Main()
    {
        // Expression Lambda
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine($"Expression Lambda Result: {add(5, 3)}");

        // Statement Lambda
        Action<string> printMessage = (message) => { Console.WriteLine($"Statement Lambda: {message}"); };
        printMessage("Hello Lambda!");
    }
}
