using System;
using System.Linq;

namespace LegoBlocks
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[][] array1 = new int[n][];
			int[][] array2 = new int[n][];
			bool isMatch = true;
			int count = 0;

			for (int i = 0; i < n; i++)
			{
				array1[i] = Console.ReadLine()
					.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse).ToArray();

			}

			for (int i = 0; i < n; i++)
			{
				array2[i] = Console.ReadLine()
					.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse).Reverse().ToArray();
			}

			int rowLength = array1[0].Length + array2[0].Length;

			for (int r = 0; r < n; r++)
			{
				int currentLength = array1[r].Length + array2[r].Length;
				if (currentLength != rowLength)
				{
					isMatch = false;
				}		
				count += currentLength;
			}
		
			if (isMatch == true)
			{
				int[] result = new int[count];

				for (int i = 0; i < n; i++)
				{
					result = array1[i].Concat(array2[i]).ToArray();
					Console.WriteLine($"[{string.Join(", ", result)}]");
				}
			}
			else
			{
				Console.WriteLine($"The total number of cells is: {count}");
			}
		}
	}
}