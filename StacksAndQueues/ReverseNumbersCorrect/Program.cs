using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbersCorrect
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
			   .Select(int.Parse)
			   .ToArray();

			Stack<int> stack = new Stack<int>();
			foreach (int number in input)
			{
				stack.Push(number);
			}

			while (stack.Count != 0)
			{
				int num = stack.Pop();
				Console.Write(num);
				Console.Write(' ');
			}
		}
	}
}

