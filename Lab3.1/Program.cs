// Single Inheritance Example

// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Derived class inheriting from Animal
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Main program for Single Inheritance
class Program
{
    static void Main()
    {
        // Create an instance of the derived class
        Dog myDog = new Dog();

        // Access methods from the base class
        myDog.Eat();

        // Access methods from the derived class
        myDog.Bark();
    }
}
