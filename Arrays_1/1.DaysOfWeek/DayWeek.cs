using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class DayWeek
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n <= 7 && n >= 0)
            {
                string[] arr = new string[8];
                arr[0] = "Invalid day!";
                arr[1] = "Monday";
                arr[2] = "Tuesday";
                arr[3] = "Wednesday";
                arr[4] = "Thursday";
                arr[5] = "Friday";
                arr[6] = "Saturday";
                arr[7] = "Sunday";
                Console.WriteLine(arr[n]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
