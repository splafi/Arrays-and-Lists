﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            numbers[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i - 1; j >= 0 && j >= i - k; j--)
                {
                    sum += numbers[j];
                }
                numbers[i] = sum;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
