using System;
using System.Linq;

namespace LegoBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] array1 = new int[n][];

            int[][] array2 = new int[n][];

            bool a = false;

            int count = 0;

            for (int i = 0; i < n; i++)

            {
                array1[i] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

            }
        
            for (int i = 0; i < n; i++)

            {

                array2[i] = Console.ReadLine()

                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)

                    .Select(int.Parse).Reverse().ToArray();

            }

            for (int i = 0; i < n - 1; i++)

            {

                if (array1[i].Length + array2[i].Length ==

                    array1[i + 1].Length + array2[i + 1].Length)

                {

                    count = array1[0].Length + array2[0].Length;

                    a = true;

                }

                else

                {

                    for (int y = 0; y < n; y++)

                    {

                        count += array1[y].Length + array2[y].Length;

                    }

                    Console.WriteLine("The total number of cells is: " + count);

                    break;

                }

            }

            if (a == true)
            {
                int[] result = new int[count];

                for (int i = 0; i < n; i++)
                {
                    result = array1[i].Concat(array2[i]).ToArray();

                    Console.WriteLine($"[{string.Join(", ", result)}]");

                }

            }
        }
    }
}
