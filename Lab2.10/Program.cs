// Question: Create a generic class and methods. Also show its implementation.

// Generic class with a generic method
public class MyGenericClass<T>
{
    private T data;

    public MyGenericClass(T value)
    {
        data = value;
    }

    public void DisplayData()
    {
        Console.WriteLine($"Data: {data}");
    }

    public T GetData()
    {
        return data;
    }
}

// Main program to demonstrate generic class and methods
class Program
{
    static void Main()
    {
        // Instantiate the generic class with different types
        MyGenericClass<int> intObj = new MyGenericClass<int>(42);
        MyGenericClass<string> stringObj = new MyGenericClass<string>("Hello, Generics!");

        // Call generic methods
        intObj.DisplayData();
        Console.WriteLine($"Data from intObj: {intObj.GetData()}");

        stringObj.DisplayData();
        Console.WriteLine($"Data from stringObj: {stringObj.GetData()}");
    }
}
