// Abstract class with an abstract method and use of 'base' keyword
public abstract class Shape
{
    // Virtual method in the base class
    public virtual void Draw()
    {
        Console.WriteLine("Generic shape drawing");
    }

    // Abstract method declaration
    public abstract void CalculateArea();

    public void DisplayInfo()
    {
        Console.WriteLine("Displaying shape information");
    }
}

// Derived class implementing the abstract method and using 'base' keyword
public class Circle : Shape
{
    // Override the virtual method with a specific implementation
    public override void Draw()
    {
        // Use the 'base' keyword to call the base class method
        base.Draw();
        Console.WriteLine("Drawing a circle");
    }

    // Implement the abstract method
    public override void CalculateArea()
    {
        Console.WriteLine("Calculating area of the circle");
    }
}

// Main program to demonstrate the abstract method and 'base' keyword
class Program
{
    static void Main()
    {
        // Create an instance of the derived class
        Circle myCircle = new Circle();

        // Call the overridden method and base class method
        myCircle.Draw(); // Calls overridden method in Circle, which calls base method in Shape
        myCircle.DisplayInfo(); // Calls method in Shape directly

        // Call the abstract method implemented in the derived class
        myCircle.CalculateArea();
    }
}
