using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
	class Program
	{
		static void Main(string[] args)
		{
			int pumpsCount = int.Parse(Console.ReadLine());
			Queue<int[]> queue = new Queue<int[]>();

			for (int petrolDistance = 0; petrolDistance < pumpsCount; petrolDistance++)
			{
				int[] pump = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

				queue.Enqueue(pump);
			}

			for (int currentStart = 0; currentStart < pumpsCount - 1; currentStart++)
			{
				int fuel = 0;
				bool isSolution = true;

				for (int pumpsPassed = 0; pumpsPassed < pumpsCount; pumpsPassed++)
				{
					int[] currentPump = queue.Dequeue();
					int pumpFuel = currentPump[0];
					int nextPumpDistance = currentPump[1];
					queue.Enqueue(currentPump);
					fuel += pumpFuel - nextPumpDistance;

					if (fuel < 0)
					{
						currentStart += pumpsPassed;
						isSolution = false;
						break;
					}
				}

				if (isSolution)
				{
					Console.WriteLine(currentStart);
					Environment.Exit(0);
				}
			}
		}
	}
}
