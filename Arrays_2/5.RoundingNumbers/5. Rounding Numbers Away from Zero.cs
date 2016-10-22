using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            double[] numbers = new double[arr.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(arr[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[1] >= 0)
                {
                    Console.WriteLine("{0}\n{1}", numbers[i], Math.Floor(numbers[i] + 0.5));
                }
                else if (numbers[1] < 0)
                {
                        Console.WriteLine("{0}\n{1}", numbers[i], Math.Ceiling(numbers[i] - 0.5));
                }
            }
        }
    }
}
