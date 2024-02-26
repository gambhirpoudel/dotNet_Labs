using System;

class Calculator
{
    // Define events for each operation
    public event Action<int, int> AdditionPerformed;
    public event Action<int, int> SubtractionPerformed;
    public event Action<int, int> MultiplicationPerformed;
    public event Action<int, int> DivisionPerformed;

    public void PerformAddition(int a, int b)
    {
        AdditionPerformed?.Invoke(a, b);
    }

    public void PerformSubtraction(int a, int b)
    {
        SubtractionPerformed?.Invoke(a, b);
    }

    public void PerformMultiplication(int a, int b)
    {
        MultiplicationPerformed?.Invoke(a, b);
    }

    public void PerformDivision(int a, int b)
    {
        DivisionPerformed?.Invoke(a, b);
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        // Subscribe to the events
        calculator.AdditionPerformed += (a, b) => Console.WriteLine($"Addition Result: {a + b}");
        calculator.SubtractionPerformed += (a, b) => Console.WriteLine($"Subtraction Result: {a - b}");
        calculator.MultiplicationPerformed += (a, b) => Console.WriteLine($"Multiplication Result: {a * b}");
        calculator.DivisionPerformed += (a, b) =>
        {
            if (b != 0)
            {
                Console.WriteLine($"Division Result: {a / (double)b}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        };

        // Perform some calculations
        calculator.PerformAddition(5, 3);
        calculator.PerformSubtraction(8, 4);
        calculator.PerformMultiplication(6, 2);
        calculator.PerformDivision(10, 2);
        calculator.PerformDivision(5, 0); // Trying to divide by zero
    }
}
