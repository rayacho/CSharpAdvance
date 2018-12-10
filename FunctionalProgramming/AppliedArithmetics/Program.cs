using System;
using System.Linq;

namespace AppliedArithmetics
{
	class Program
	{

		static void Main(string[] args)
		{
			int i = 0;
			Func<int, int> add = x => x + 1;
			Func<int, int> multiply = x => x * 2;
			Func<int, int> subtract = x => x - 1;
			Action<int> print = x => Console.Write(x + " ");
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			string command = "";

			while (command != "end")
			{
				command = Console.ReadLine();

				switch (command)
				{
					case "add":
						{
							foreach (int number in input)
							{
								input[i] = (add(number));
								i++;
							}
							i = 0;
						}
						break;
					case "multiply":
						{
							foreach (int number in input)
							{
								input[i] = (multiply(number));
								i++;
							}
							i = 0;
						}
						break;
					case "subtract":
						{
							foreach (int number in input)
							{
								input[i] = (subtract(number));
								i++;
							}
							i = 0;
						}
						break;
					case "print":
						{
							foreach (int number in input)
							{
								print(number);
							}
							Console.WriteLine();
						}
						break;
				}
			}

			Environment.Exit(0);
		}
	}
}


