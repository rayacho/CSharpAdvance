using System;
using System.Collections.Generic;
using System.Linq;
namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse);
            var stack = new Stack<int>();
            foreach(var n in input)
            {
                stack.Push(n);
            }
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.ReadKey();
        }
    }
}
