using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse);
            var stack = new Stack<int>();
            var nNumbers = Console.ReadLine().Split(' ').Select(int.Parse);
            var existence = "false";
            foreach (var number in input)
            {
                stack.Push(number);
            }
            int n = stack.Pop();
            int s = stack.Pop();
            int x = stack.Pop();
            var stackOfNumbers = new Stack<int>();
            var stackOfNumbers2 = new Stack<int>();
            foreach(var chislo in nNumbers)
            {
                stackOfNumbers.Push(chislo);
                stackOfNumbers2.Push(chislo);
                if(chislo == x)
                {
                    existence = "true";
                }
            }
            var smallestStack = new Stack<int>();
            smallestStack.Push(stackOfNumbers.Peek());
            for(int j = 0; j < stackOfNumbers2.Count; j++)
            {
                if(smallestStack.Peek() > stackOfNumbers2.Peek())
                {
                    smallestStack.Push(stackOfNumbers2.Pop());
                }
            }
            for(int i = 0; i < s; i++)
            {
                stackOfNumbers.Pop();
            }
            if(existence == "true")
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(smallestStack.Pop());
            }
        }
    }
}
