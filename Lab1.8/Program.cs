//Write a program to arrange the numbers (in array) in ascending order using bubble sort. 
using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the size of the array
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());

        // Create an array and initialize it with user input
        int[] numbers = new int[size];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Perform bubble sort to arrange the array in ascending order
        BubbleSort(numbers);

        // Display the sorted array
        Console.WriteLine("Sorted Array in Ascending Order:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
    }

    // Function to perform Bubble Sort on an array
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // Swap if the element found is greater than the next element
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
