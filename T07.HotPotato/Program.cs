using System;
using System.Collections.Generic;

namespace T07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int reps = int.Parse(Console.ReadLine());
            int currReps = 1;
            Queue<string> queue = new Queue<string>(names);

            while (queue.Count> 1)
            {
                var kidWithPatato = queue.Dequeue();
                if (currReps != reps)
                {
                    currReps++;
                    queue.Enqueue(kidWithPatato);
                }
                else
                {
                    currReps = 1;
                    Console.WriteLine($"Removed {kidWithPatato}");
                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
           
        }
    }
}
