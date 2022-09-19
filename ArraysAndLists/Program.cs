using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myIntArray = { 35, 3, 5, 16, 20, 18, 9, 43, 10, 12 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int num in myIntArray)
            {
                if (num % 2 == 0) evens.Add(num);
                else odds.Add(num);
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("These are the even numbers: ");
            foreach (int num in evens)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("These are the odd numbers: ");
            foreach (int num in odds)
            {
                Console.WriteLine(num);
            }
        }
    }
}
