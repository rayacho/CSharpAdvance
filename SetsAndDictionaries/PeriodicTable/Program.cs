using System;
using System.Collections.Generic;

namespace PeriodicTable
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			SortedDictionary<string, int> elements = new SortedDictionary<string, int>();

			for(int i = 0; i < n; i++)
			{
				string[] line = Console.ReadLine().Split(' ');

				foreach(string element in line)
				{
					if (!elements.ContainsKey(element))
						elements.Add(element, 1);
				}
			}

			foreach(var element in elements)
			{
				var key = element.Key;
				Console.Write(key + " ");
			}
		}
	}
}
