// Write a program that shows the overloading of method and operators (binary and unary).

// Define a class for mathematical operations
public class MathOperations
{
    // Overloaded method to add integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method to add doubles
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Overloaded binary operator +
    public static MathOperations operator +(MathOperations operand1, MathOperations operand2)
    {
        MathOperations result = new MathOperations();
        // Custom logic for adding two MathOperations objects
        // (Note: The logic here needs to be implemented based on the actual requirements)
        return result;
    }

    // Overloaded unary operator -
    public static MathOperations operator -(MathOperations operand)
    {
        MathOperations result = new MathOperations();
        // Custom logic for negating a MathOperations object
        // (Note: The logic here needs to be implemented based on the actual requirements)
        return result;
    }
}

// Main program to demonstrate method and operator overloading
class Program
{
    static void Main()
    {
        // Create an instance of the class
        MathOperations mathObj = new MathOperations();

        // Call overloaded methods
        Console.WriteLine("Add integers: " + mathObj.Add(5, 3));
        Console.WriteLine("Add doubles: " + mathObj.Add(5.5, 3.3));

        // Use overloaded operators
        MathOperations result1 = mathObj + mathObj;
        MathOperations result2 = -mathObj;

        // Additional logic for overloaded operators can be added in the class.
        // (Note: The logic in the overloaded operators needs to be implemented based on the actual requirements)
    }
}
