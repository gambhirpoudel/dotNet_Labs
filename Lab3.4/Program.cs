// Multiple Inheritance (using interfaces) Example

// Interface 1
public interface IWalkable
{
    void Walk();
}

// Interface 2
public interface ISwimmable
{
    void Swim();
}

// Class implementing multiple interfaces
public class Human : IWalkable, ISwimmable
{
    public void Walk()
    {
        Console.WriteLine("Human is walking");
    }

    public void Swim()
    {
        Console.WriteLine("Human is swimming");
    }
}

// Main program for Multiple Inheritance
class Program
{
    static void Main()
    {
        // Create an instance of the class
        Human person = new Human();

        // Access methods from the interfaces
        person.Walk();
        person.Swim();
    }
}
