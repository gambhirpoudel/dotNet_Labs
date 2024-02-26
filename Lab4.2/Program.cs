using System;

class MyClass
{
    // Define an event
    public event EventHandler MyEvent;

    public void InvokeEvent()
    {
        // Raise the event
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        MyClass myClass = new MyClass();

        // Subscribe to the event
        myClass.MyEvent += HandleEvent;

        // Invoke the method, which will raise the event
        myClass.InvokeEvent();
    }

    static void HandleEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Event handled!");
    }
}
