using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseArrayIntegers
{
    class ReverseArrayIntegers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
