//Write a program to show the implementation of indexer in a class. 
using System;

public class Library
{
    private string[] books;

    // Constructor to initialize the array of books
    public Library(int capacity)
    {
        books = new string[capacity];
    }

    // Indexer implementation
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= books.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return books[index];
        }
        set
        {
            if (index < 0 || index >= books.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            books[index] = value;
        }
    }

    // Method to display all books in the library
    public void DisplayBooks()
    {
        Console.WriteLine("Books in the library:");
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"Book {i + 1}: {books[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a library with a capacity of 5 books
        Library myLibrary = new Library(5);

        // Use the indexer to add books to the library
        myLibrary[0] = "The Catcher in the Rye";
        myLibrary[1] = "To Kill a Mockingbird";
        myLibrary[2] = "1984";
        myLibrary[3] = "Pride and Prejudice";
        myLibrary[4] = "The Great Gatsby";

        // Display all books in the library
        myLibrary.DisplayBooks();

        // Use the indexer to retrieve a book
        Console.WriteLine("\nRetrieving book at index 2:");
        Console.WriteLine($"Book 2: {myLibrary[2]}");
    }
}

