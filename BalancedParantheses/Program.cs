using System;
using System.Collections.Generic;

namespace BalancedParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<string>();
            int times = 0;
            string balance = "NO";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[input.Length - i])
                {
                    times++;
                }
            }

            int timesNeeded = input.Length / 2;

            if (times == timesNeeded)
            {
                balance = "YES";
                stack.Push(balance);
            }
            else
            {
                stack.Push(balance);
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
