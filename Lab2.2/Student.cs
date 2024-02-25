using System;

namespace YourNamespace
{
    public class Student
    {
        // Class variable to keep track of the total number of students
        private static int totalStudents = 0;

        // Instance variables
        public int StudentId { get; private set; }
        public string Name { get; set; }
        private int age;
        public string Grade { get; set; }

        // Parameterized constructor
        public Student(int studentId, string name, int age, string grade)
        {
            Console.WriteLine("Parameterized constructor called.");
            // Using "this" to differentiate between instance variable and parameter with the same name
            this.StudentId = studentId;
            this.Name = name;
            this.Age = age;
            this.Grade = grade;

            // Increment the total number of students
            totalStudents++;
        }

        // Parameterless constructor
        public Student()
        {
            Console.WriteLine("Parameterless constructor called.");
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
}
