using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<string, List<string>> colours = new Dictionary<string, List<string>>();
			Dictionary<string, int> clothes = new Dictionary<string, int>();

			for(int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ', ',');
				List<string> clooths = new List<string>();
				string[] clothing = { };
				int p = 0; 

				for (int j = 2; j < input.Length; j++)
				{
					clothing[p] = input[j];
					p++;
				}

				foreach(var cloth in clothing)
				{ 
					if (!clothes.ContainsKey(cloth))
						clothes.Add(cloth, 1);
					else
						clothes[cloth]++;

					clooths.Add(cloth);
				}

				var colour = input[0];
				if (!colours.ContainsKey(colour))
					colours.Add(colour, clooths);
			}

			var needed = Console.ReadLine().Split(' ');
			var color = needed[0];
			var typeOfClothing = needed[1];

			foreach(var colouur in colours)
			{
				Console.WriteLine($"{colouur.Key} clothes:");
				foreach(var c in clothes)
				{
					Console.Write($"* {c.Key} - {c.Value}");
					if (color == colouur.Key && typeOfClothing == c.Key)
						Console.Write(" (found!)");
					Console.WriteLine();
				}
			}
		}
	}
}
