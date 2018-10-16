using System;
using System.Linq;
using 

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).toArray();
            char[,] matrix = new char[input[0], input[1]];
            char a = 'a';
            char b = 'a';
            for (int rows = 0; rows < input[0]; rows++)
            {
                for (int cols = 0; cols < input[1]; cols++)
                {
                    Console.Write(a);
                    Console.Write(b);
                    Console.Write(a);
                    Console.Write(" ");
                    b++;
                }
                Console.WriteLine();
                a++;
                b = a;
            }
        }
    }
}
