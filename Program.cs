using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object:
            var list = new List<object>();

            // Add the following values to the list: 7, 28, -1, true, "chair":
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");

            // Loop through the list and print all values:
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // Add all values that are Int type together and output the sum:
            int sum = 0;
            foreach (var item in list)
            {
                if(list is int) {
                    sum += (int)list;
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
