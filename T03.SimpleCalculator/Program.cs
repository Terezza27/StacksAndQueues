using System;
using System.Collections.Generic;

namespace T03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<int> stackPos = new Stack<int>();
            Stack<int> stackNeg = new Stack<int>();
            int sumPos = 0;
            int sumNeg = 0;
            for (int i = 0; i < input.Length; i+=2)
            {
                if (i== 0)
                {
                    stackPos.Push(input[0]);
                }
                else if (i - 1 == '+')
                {
                    stackPos.Push(input[i]);
                }
                else if (i - 1 == '-')
                {
                    stackNeg.Push(input[i]);
                }
            }

            while (stackPos.Count > 0)
            {
                sumPos += stackPos.Pop();
            }
            while (stackNeg.Count > 0)
            {
                sumNeg += stackNeg.Pop();
            }
            int sum = sumPos - sumNeg;
            Console.WriteLine(sum);
        }
    }
}
