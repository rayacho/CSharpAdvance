using System;
using System.Linq;

namespace RubiksMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];
            int inp = 1;
            for(int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for(int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = inp;
                    inp++;
                }
            }
        }
    }
}
