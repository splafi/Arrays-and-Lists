using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            for (int i = arr.Length-1; i >= 0 ; i--)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
