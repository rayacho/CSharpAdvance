using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace _1.Regeh
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex rgx = new Regex(@"\[[^\[\]\s]+<(\d+)REGEH(\d+)>[^\[\]\s]+\]");
			string input = Console.ReadLine();
			MatchCollection matches = rgx.Matches(input);
			int[] indexes = new int[matches.Count * 2];

			for (int i = 0; i < matches.Count; i++)
			{
				Match match = matches[i];
				indexes[i * 2] = (int.Parse(match.Groups[1].Value) + (i == 0 ? 0 : indexes[i * 2 - 1])) % input.Length;
				indexes[i * 2 + 1] = (int.Parse(match.Groups[2].Value) + indexes[i * 2]) % input.Length;
			}

			Console.WriteLine(string.Join("", indexes.Select(index => input[index])));
		}
	}
}
