//Write a program to demonstrate the virtual method and its use. 
using System;

// Base class with a virtual method
public class Animal
{
    // Virtual method
    public virtual void MakeSound()
    {
        Console.WriteLine("Generic animal sound");
    }
}

// Derived class overriding the virtual method
public class Dog : Animal
{
    // Override the virtual method with a specific implementation
    public override void MakeSound()
    {
        Console.WriteLine("Bark! Bark!");
    }
}

// Another derived class also overriding the virtual method
public class Cat : Animal
{
    // Override the virtual method with a specific implementation
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of derived classes
        Animal genericAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        // Call the virtual method on different instances
        Console.WriteLine("Generic Animal Sound:");
        genericAnimal.MakeSound();

        Console.WriteLine("\nDog Sound:");
        myDog.MakeSound();

        Console.WriteLine("\nCat Sound:");
        myCat.MakeSound();
    }
}
