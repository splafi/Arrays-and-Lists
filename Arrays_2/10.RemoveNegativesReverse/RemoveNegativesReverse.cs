using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RemoveNegativesReverse
{
    class RemoveNegativesReverse
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    nums.Remove(nums[i]);
                }
            }
            nums.Reverse();
            Console.Write(string.Join(", ", nums));
        }
    }
}
