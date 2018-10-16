using System;
using System.Collections.Generic;
using System.Linq;

namespace SequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            queue.Enqueue(start);

            for (int i = 0; i < 50; i++)
            {
                long n = queue.Dequeue();
                Console.Write(n + " ");
                queue.Enqueue(n + 1);
                queue.Enqueue(2 * n + 1);
                queue.Enqueue(n + 2);
            }
        }
    }
}
