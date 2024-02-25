//Write a C# program for matrix addition with the help of function add (int [,] a, int [,] b). 
using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the dimensions of the matrices
        Console.WriteLine("Enter the number of rows for the matrices:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns for the matrices:");
        int columns = Convert.ToInt32(Console.ReadLine());

        // Create two matrices and initialize them with user input
        int[,] matrixA = ReadMatrix(rows, columns, "Matrix A");
        int[,] matrixB = ReadMatrix(rows, columns, "Matrix B");

        // Display the matrices
        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA);

        Console.WriteLine("Matrix B:");
        DisplayMatrix(matrixB);

        // Perform matrix addition and display the result
        int[,] resultMatrix = Add(matrixA, matrixB);

        Console.WriteLine("Result Matrix (Matrix A + Matrix B):");
        DisplayMatrix(resultMatrix);
    }

    // Function to read a matrix from user input
    static int[,] ReadMatrix(int rows, int columns, string matrixName)
    {
        Console.WriteLine($"Enter values for {matrixName}:");

        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter value for element [{i + 1},{j + 1}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        return matrix;
    }

    // Function to add two matrices
    static int[,] Add(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);

        int[,] resultMatrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return resultMatrix;
    }

    // Function to display a matrix
    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
