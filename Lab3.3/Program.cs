// Hierarchical Inheritance Example

// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Derived class 1 inheriting from Animal
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Derived class 2 inheriting from Animal
public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}

// Main program for Hierarchical Inheritance
class Program
{
    static void Main()
    {
        // Create instances of the derived classes
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        // Access methods from the base class
        myDog.Eat();
        myCat.Eat();

        // Access methods from the derived classes
        myDog.Bark();
        myCat.Meow();
    }
}
