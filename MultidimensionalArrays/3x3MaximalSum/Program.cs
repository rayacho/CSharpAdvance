using System;
using System.Linq;

namespace _3x3MaximalSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] rowsAndColumns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];
			int maxSum = int.MinValue;
			int startRow = 0;
			int startCol = 0;

			for (int rows = 0; rows < matrix.GetLength(0); rows++)
			{
				int[] rowValues = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				for (int cols = 0; cols < matrix.GetLength(1); cols++)
				{
					matrix[rows, cols] = rowValues[cols];
				}
			}

			for (int row = 0; row < matrix.GetLength(0) - 2; row++)
			{
				for (int col = 0; col < matrix.GetLength(1) - 2; col++)
				{
					int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1]
						+ matrix[row + 1, col + 1]
						+ matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2] + matrix[row + 2, col]
						+ matrix[row + 2, col + 1];

					if (currentSum > maxSum)
					{
						maxSum = currentSum;
						startCol = col;
						startRow = row;
					}
				}
			}

			Console.WriteLine("Sum = " + maxSum);
			for (int r = startRow; r <= startRow + 2; r++)
			{
				for (int c = startCol; c <= startCol + 2; c++)
				{
					Console.Write(matrix[r, c] + " ");
				}

				Console.WriteLine();
			}
		}
	}
}
