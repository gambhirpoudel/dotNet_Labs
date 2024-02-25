// Question: Create a fully featured structure (Struct) and show its implementation.

// Define a struct
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Custom constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method in a struct
    public void DisplayCoordinates()
    {
        Console.WriteLine($"Coordinates: ({X}, {Y})");
    }
}

// Main program to demonstrate the fully featured structure
class Program
{
    static void Main()
    {
        // Create an instance of the struct
        Point myPoint = new Point(3, 7);

        // Access properties and call method
        Console.WriteLine($"X: {myPoint.X}, Y: {myPoint.Y}");
        myPoint.DisplayCoordinates();
    }
}
