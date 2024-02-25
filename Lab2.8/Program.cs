// Question: Create an interface, implement in a class, and demonstrate.

// Define an interface
public interface IDrawable
{
    void Draw();
}

// Implement the interface in a class
public class Rectangle : IDrawable
{
    // Implement the interface method
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

// Main program to demonstrate interface implementation
class Program
{
    static void Main()
    {
        // Create an instance of the class implementing the interface
        Rectangle myRectangle = new Rectangle();

        // Call the interface method
        myRectangle.Draw();
    }
}
