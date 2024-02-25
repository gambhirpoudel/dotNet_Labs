// Multilevel Inheritance Example

// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Intermediate class inheriting from Animal
public class Mammal : Animal
{
    public void Breathe()
    {
        Console.WriteLine("Mammal is breathing");
    }
}

// Derived class inheriting from Mammal
public class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Main program for Multilevel Inheritance
class Program
{
    static void Main()
    {
        // Create an instance of the derived class
        Dog myDog = new Dog();

        // Access methods from the base class
        myDog.Eat();

        // Access methods from the intermediate class
        myDog.Breathe();

        // Access methods from the derived class
        myDog.Bark();
    }
}
