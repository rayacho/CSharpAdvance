using System;
using System.Linq;
namespace GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            var sizes = new int[3];
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            foreach (var number in input)
            {
                sizes[number % 3]++;
            }

            int[][] jaggedArray = new int[3][];

			for (int counter = 0; counter < sizes.Length; counter++)
            {
                jaggedArray[counter] = new int[sizes[counter]];
            }

            int[] index = new int[3];

			foreach (var number in input)
            {
                var remainder = number % 3;
                jaggedArray[remainder][index[remainder]] = number;
                index[remainder]++;
            }

            for(int rows = 0; rows < jaggedArray.Length; rows++)
            {
                for(int columns = 0; columns < jaggedArray[rows].Length; columns++)
                {
                    Console.Write(jaggedArray[rows][columns]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
