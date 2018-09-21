using System;
using System.Linq;
namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColumns = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.None).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];
            int s = 0;
            for(int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var rowValues = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
                for(int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows,cols] = rowValues[cols];
                    s += matrix[rows, cols];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(s);
        }
    }
}
