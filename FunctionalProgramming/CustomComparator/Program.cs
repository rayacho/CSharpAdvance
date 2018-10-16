using System;
using System.Linq;

namespace CustomComparator
{
	class Program
	{
		static void Main(string[] args)
		{
			Predicate<int> isOdd = x => x % 2 != 0;
			Predicate<int> isEven = x => x % 2 == 0;

			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] evenNumbers = { };
			int[] oddNumbers = { };
			int i = 0, j = 0, buf;

			foreach (var number in input)
			{
				if (isOdd.Invoke(number))
				{
					oddNumbers[i] = number;
					i++;
				}

				else if(isEven.Invoke(number))
				{
					evenNumbers[j] = number;
					j++;
				}
			}
			
			for(int k = 0; k < evenNumbers.Length - 1; k++)
			{
				if(evenNumbers[k] > evenNumbers[k+1])
				{
					buf = evenNumbers[k];
					evenNumbers[k] = evenNumbers[k + 1];
					evenNumbers[k + 1] = buf;
				}
			}

			for (int m = 0; m < evenNumbers.Length - 1; m++)
			{
				if (evenNumbers[m] > evenNumbers[m + 1])
				{
					buf = evenNumbers[m];
					evenNumbers[m] = evenNumbers[m + 1];
					evenNumbers[m + 1] = buf;
				}
			}

			foreach(var even in evenNumbers)
			{
				Console.Write(even + " ");
			}

			foreach(var odd in oddNumbers)
			{
				Console.Write(odd + " ");
			}
		}
	}
}
