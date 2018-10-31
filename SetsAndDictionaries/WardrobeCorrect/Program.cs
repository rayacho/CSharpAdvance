using System;
using System.Collections.Generic;
using System.Linq;

namespace WardrobeCorrect
{
	class Program
	{
		static void Main(string[] args)
		{
				int number = int.Parse(Console.ReadLine());
				var wardrobe = new Dictionary<string, Dictionary<string, int>>();

				for (int i = 0; i < number; i++)
				{
					string[] inputLineColor = Console.ReadLine().Split(new string[] { " -> " },
						StringSplitOptions.RemoveEmptyEntries).ToArray();
					string color = inputLineColor[0];

					if (!wardrobe.ContainsKey(color))
					{
						wardrobe[color] = new Dictionary<string, int>();
					}

					string clothes = inputLineColor[1];
					string[] inputClotes = clothes.Split(new char[] { ',' },
						StringSplitOptions.RemoveEmptyEntries).ToArray();

					foreach (string item in inputClotes)
					{
						if (!wardrobe[color].ContainsKey(item))
						{
							wardrobe[color].Add(item, 0);
						}

						wardrobe[color][item]++;
					}
				}

				string[] inputFinal = Console.ReadLine().Split(new[] { ' ' },
					StringSplitOptions.RemoveEmptyEntries).ToArray();

				foreach (var kvpColor in wardrobe)
				{
					Console.WriteLine($"{kvpColor.Key} clothes:");

					foreach (var kvpClothes in kvpColor.Value)
					{
						if (kvpColor.Key == inputFinal[0] && kvpClothes.Key == inputFinal[1])
						{
							Console.WriteLine($"* {kvpClothes.Key} - {kvpClothes.Value} (found!)");
						}
						else
						{
							Console.WriteLine($"* {kvpClothes.Key} - {kvpClothes.Value}");
						}
					}
				}
			}
		}
	}