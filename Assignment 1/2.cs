using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    internal class _2
    {
        static void Main()
        {
            string text = "123abc";
            try
            {
                int number = Convert.ToInt32(text);
                Console.WriteLine("Converted number: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: the string is not in a correct format for conversion.");
            }
        }
    }
}
