using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class _6
    {
        static void Main()
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = list1;

            list2.Add(4);

            Console.WriteLine("list1: " + string.Join(", ", list1));
            Console.WriteLine("list2: " + string.Join(", ", list2));
        }
    }
}
