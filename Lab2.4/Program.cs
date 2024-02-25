//Show the dynamic binding (polymorphism) through a clear program. 
using System;

// Define an interface
public interface IShape
{
    void Draw();
}

// Base class
public class Shape : IShape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Derived class with method override
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// Another derived class with method override
public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Program
{
    static void Main()
    {
        // Using dynamic binding through polymorphism
        Shape shape1 = new Circle();
        Shape shape2 = new Square();

        // Calling Draw method on different shapes
        DrawShape(shape1);
        DrawShape(shape2);
    }

    // Method that accepts any object implementing IShape
    static void DrawShape(IShape shape)
    {
        shape.Draw();
    }
}
