using System;
using System.Collections.Generic;

namespace T08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int canPass = int.Parse(Console.ReadLine());
            string cmd = Console.ReadLine();
            int count = 0;
            int passed = 0;
            Queue<string> queue = new Queue<string>();
            while (cmd != "end")
            {
                if (cmd == "green")
                {
                    while (queue.Count != queue.Count - canPass)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                        passed++;
                    }
                    count = 0;
                }
                else
                {
                    queue.Enqueue(cmd);
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
