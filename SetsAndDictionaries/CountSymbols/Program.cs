using System;
using System.Collections.Generic;

namespace CountSymbols
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] input = Console.ReadLine().ToCharArray();
			SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

			foreach(char symbol in input)
			{
				if (!symbols.ContainsKey(symbol))
					symbols.Add(symbol, 1);
				else symbols[symbol]++;
			}

			foreach(var symbol in symbols)
			{
				char key = symbol.Key;
				int value = symbol.Value;
				Console.WriteLine($"{key}: {value} time/s");
			}
		}
	}
}
