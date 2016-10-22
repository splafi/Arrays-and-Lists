using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int[] nums = new int[arr.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(arr[i]);
            }

            var squares = new List<int>();

            foreach (var num in nums)
            {
                double sqrt = Math.Sqrt(num); 
                if (sqrt == (int)sqrt)
                {
                    squares.Add(num);
                }
            }
            squares.Sort((a,b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
