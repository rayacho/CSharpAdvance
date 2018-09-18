﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicStackOperationsCorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < commands[0] && i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < commands[1] && stack.Count > 0; i++)
            {
                stack.Pop();
            }

            Console.WriteLine(stack.Count == 0 ? "0" : stack.Contains(commands[2]) ? "true" : $"{stack.Min()}");
        }
    }
}
