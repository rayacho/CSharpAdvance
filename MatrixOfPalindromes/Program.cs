using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColumns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int r = rowsAndColumns[0];
            int c = rowsAndColumns[1];
            int[,] matrix = new int[r,c];
            for(int rows = 0; rows < r; rows++)
            {
                matrix[0, c] = alphabet[rows];
                matrix[r, c] = alphabet[rows];
                for (int cols = 0; cols < c; cols++)
                {
                    
                }
                Console.WriteLine();
            }
        }
    }
}
