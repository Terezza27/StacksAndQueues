using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(nums); 
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int num = queue.Dequeue();
               
                if (num % 2 == 0)
                {
                    count++;
                    if (count == 1)
                    {
                        Console.Write($"{num}");
                    }
                    else
                    {
                        Console.Write($", {num}");
                    }

                }
            }
        }
    }
}
