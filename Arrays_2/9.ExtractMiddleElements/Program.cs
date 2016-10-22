using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int[] nums = new int[arr.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(arr[i]);
            }

            if (nums.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {nums[(nums.Length - 1) / 2]}, {nums[nums.Length / 2]} }}");
            }

            else if (nums.Length % 2 != 0 && nums.Length!=1)
            {
                Console.WriteLine($"{{ {nums[(nums.Length) / 2 - 1]}, {nums[nums.Length / 2]}, {nums[(nums.Length + 1) / 2]} }}");
            }
            else if (nums.Length==1)
            {
                Console.WriteLine($"{{ {nums[0]} }}");
            }
        }
    }
}
