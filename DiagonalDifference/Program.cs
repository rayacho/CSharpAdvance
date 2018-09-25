using System;
using System.Linq;
using System.Collections.Generic;
namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int primarySum = 0, secondarySum = 0, difference = 0;

            for(int rows = 0; rows < n; rows++)
            {
                var rowValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = rowValues[cols];
                }
            }
            primarySum = matrix[0, 0] + matrix[n - 1, n - 1];
            secondarySum = matrix[0, n - 1] + matrix[n - 1, 0];

            for (int rows = 1; rows < n - 2; rows++)
            {
                for (int cols = 1; cols < n - 2; cols++)
                {
                    primarySum += matrix[rows, cols];
                }
            }
            

            for (int rows = n - 2; rows < 1; rows--)
            {
                for (int cols = n - 2; cols < 1; cols--)
                {
                    secondarySum += matrix[rows, cols];
                }
            }

         
            difference = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(difference);
            Console.ReadKey();
        }
    }
}
