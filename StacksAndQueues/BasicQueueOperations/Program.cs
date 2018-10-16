using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
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

            Queue<int> queue = new Queue<int>();


            for (int i = 0; i < commands[0] && i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < commands[1] && queue.Count > 0; i++)
            {
                queue.Dequeue();
            }

            Console.WriteLine(queue.Count == 0 ? "0" : queue.Contains(commands[2]) ? "true" : $"{queue.Min()}");
        }
    }
}
