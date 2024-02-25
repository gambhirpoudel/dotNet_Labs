// Sealed Class and Method Example

// Sealed class
public sealed class SealedClass
{
    public void DisplayMessage()
    {
        Console.WriteLine("This is a sealed class");
    }
}

// Attempting to derive from a sealed class will result in a compilation error
// public class DerivedClass : SealedClass { }

// Main program for Sealed Class and Method
class Program
{
    static void Main()
    {
        // Create an instance of the sealed class
        SealedClass sealedObj = new SealedClass();

        // Access the sealed method
        sealedObj.DisplayMessage();
    }
}
