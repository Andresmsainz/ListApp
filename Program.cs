using System;
using System.Collections.Generic; // Used for the list

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List App!");

            // Creating
            Console.WriteLine("Entering Creating Section");

            List<string> firstList = new List<string>();
            IList<string> secondList = new List<string>();

            Console.WriteLine("-------------------------");

            // Adding
            Console.WriteLine("Entering Adding Section");

            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("China");
            firstList.Add("Germany");

            Console.WriteLine("-------------------------");

            // Displaying
            Console.WriteLine("Entering Displaying Section");

            foreach (var item in firstList)
            {
                Console.WriteLine("Item = " + item);
            }
            Console.WriteLine("-------------------------");

            // Index
            Console.WriteLine("Entering Indexing Section");

            Console.WriteLine("Retreving Value of Index 2 = " + firstList[2]);
            Console.WriteLine("Retreving Value of Index 0 = " + firstList[0]);

            Console.WriteLine("-------------------------");

            // Capacity
            Console.WriteLine("Entering Capacity Section");

            Console.WriteLine("Current Capacity = " + firstList.Count);

            Console.WriteLine("-------------------------");
            // Sorting
            Console.WriteLine("Entering Sorting Section");

            firstList.Sort();

            foreach (var item in firstList)
            {
                Console.WriteLine("Item = " + item);
            }
            Console.WriteLine("-------------------------");

            // Reversing

            Console.WriteLine("Entering Reversing Section");

            firstList.Reverse();
            foreach (var item in firstList)
            {
                Console.WriteLine("Item = " + item);
            }

            Console.WriteLine("-------------------------");

            // Removing
            Console.WriteLine("Entering Removing Section");

            Console.WriteLine("Removing Value China");
            firstList.Remove("China");
            Console.WriteLine("Removing Index 0 Egypt");
            firstList.RemoveAt(0);

            foreach (var item in firstList)
            {
                Console.WriteLine("Item = " + item);
            }

            Console.WriteLine("-------------------------");
            // Remove All
            Console.WriteLine("Entering Remove All Section");

            firstList.Clear();

            foreach (var item in firstList)
            {
                Console.WriteLine("Item = " + item);
            }

            Console.WriteLine("-------------------------");

            // Contains
            Console.WriteLine("Entering Contains Section");
            Console.WriteLine("Adding all elements again");

            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("China");
            firstList.Add("Germany");

            Console.WriteLine("Does the list contain England = " + firstList.Contains("England"));
            Console.WriteLine("Does the list contain Uruguay = " + firstList.Contains("Uruguay"));

            Console.WriteLine("-------------------------");
        }
    }
}
