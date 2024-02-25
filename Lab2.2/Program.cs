//Demonstrate the use of this, static constructor and object initializers in a class and implement.
using System;

namespace YourNamespace
{
    class Program
    {
        static void Main()
        {
            // Using the parameterized constructor and object initializer for student1
            Student student1 = new Student(1, "John Doe", 20, "A")
            {
                // Modifying properties after object creation
                Name = "Modified John Doe",
                Grade = "B"
            };

            // Displaying student information
            student1.DisplayInfo();
            Console.WriteLine();

            // Accessing class variable using class method
            Console.WriteLine($"Total Students: {Student.GetTotalStudents()}");
        }
    }
}
