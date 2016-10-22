using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Condense_Array_to_Number
{
    class CondenseArrayNumber
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int[] numbers = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }

            while (numbers.Length>1 )
            {
                int[] condensed = new int[numbers.Length - 1];
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                    numbers[i] = condensed[i];
                    numbers.Length = numbers.Length - 1;
                }
            }

            Console.WriteLine(numbers);
        }
    }
}
