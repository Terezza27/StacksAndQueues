using System;
using System.Collections.Generic;

namespace T06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            while (input != "End")
            {
                if (input=="Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            int count = 0;
            while (queue.Count > 0)
            {
                queue.Dequeue();
                count++;
            }
            Console.WriteLine($"{count} people remaining.");
        }
    }
}
