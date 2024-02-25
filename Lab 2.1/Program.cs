//Create a class student with basic fields (assume yourself) properties and methods.
//Create constructors (both types) and destructor(finalizer) too and show the implementation. 
using System;

public class Student
{
    // Class variable to keep track of the total number of students
    private static int totalStudents = 0;

    // Instance variables
    public int StudentId { get; private set; }
    public string Name { get; set; }
    private int age;
    public string Grade { get; set; }

    // Constructors
    public Student(int studentId, string name, int age, string grade)
    {
        StudentId = studentId;
        Name = name;
        Age = age;
        Grade = grade;

        // Increment the total number of students
        totalStudents++;
    }

    // Property for accessing and setting the age with validation
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age must be a positive integer.");
            }
            age = value;
        }
    }

    // Method to print student information
    public void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade: {Grade}");
    }

    // Method to get the total number of students
    public static int GetTotalStudents()
    {
        return totalStudents;
    }

    // Destructor (finalizer) method
    ~Student()
    {
        // Decrement the total number of students when an instance is finalized
        totalStudents--;
        Console.WriteLine($"Student {Name} with ID {StudentId} has been finalized.");
    }
}

class Program
{
    static void Main()
    {
        // Creating instances of the Student class
        Student student1 = new Student(1, "John Doe", 20, "A");
        Student student2 = new Student(2, "Jane Doe", 22, "B");

        // Displaying student information
        student1.DisplayInfo();
        Console.WriteLine();

        student2.DisplayInfo();
        Console.WriteLine();

        // Accessing class variable using class method
        Console.WriteLine($"Total Students: {Student.GetTotalStudents()}");

        // The following line is optional since the program will end, and the destructor will be called automatically.
        // Uncomment if you want to explicitly finalize the instances before the program ends.
        // GC.Collect();

        // No need to explicitly delete instances in C#, as the garbage collector will handle it.
    }
}
