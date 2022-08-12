using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(arrNum);
            string cmd = Console.ReadLine().ToLower();
            int sum = 0;

            while (cmd != "end")
            {
                string[] splitedCmd = cmd.Split().ToArray();

                if (splitedCmd[0] == "add")
                {
                    stack.Push(int.Parse(splitedCmd[1]));
                    stack.Push(int.Parse(splitedCmd[2]));
                }
                else if (splitedCmd[0] == "remove")
                {
                    if (stack.Count >= int .Parse(splitedCmd[1]))
                    {
                        for (int i = 0; i < int.Parse(splitedCmd[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                cmd = Console.ReadLine().ToLower();
            }
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
