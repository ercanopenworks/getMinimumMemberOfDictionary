using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace getMinimumMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 6, 5, 2, 5, 9, 6, 9, 2, 3, 3, 3 }; // unsorted array

            int mostCommon = arr.GroupBy(x => x)
                    .OrderByDescending(grp => grp.Count()) // First precedence = frequency
                    .ThenBy(grp => grp.Key) // Second precedence is lowest number first
                    .Select(bcd => bcd.Key)
                    .FirstOrDefault();

            Console.Write(mostCommon);
            Console.Read();
        }
    }
}
