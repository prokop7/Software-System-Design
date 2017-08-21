using System;

namespace bagProject
{
    class Program
    {
        /// <summary>
        /// Task 1. Different examples of using Bag.
        /// </summary>
        public static void Task1Example()
        {
            Console.WriteLine("\n\n----------- Task #1. Bag(MultiSet) -------------");
        
            var bag1 = new Bag<string>();
            var bag2 = new Bag<string>();
            var bag3 = new Bag<string>();
            bag1.Add("A", 3);
            bag1.Add("B", 2);
            bag1.Add("C", 2);
            bag2.Add("A", 2);
            bag2.Add("B", 1);
            bag3.Add("A", 2);
            bag3.Add("B", 1);
            Console.WriteLine(bag1);
            bag1 -= bag2;
            Console.WriteLine(bag1);
            bag1.Remove("C", 1);
            Console.WriteLine(bag1);
            Console.WriteLine(bag2 == bag3);
        }

        /// <summary>
        /// Task 2. Bag with limit on amount of objects.
        /// </summary>
        public static void Task2Example()
        {
            Console.WriteLine("\n\n----------- Task #2. ConsBag -------------");
        
            var consBag = new ConsBag<string>(5);
            consBag.Add("El", 3);
            Console.WriteLine(consBag);
            consBag.Add("El", 3);
            Console.WriteLine(consBag);
        }

        static void Main(string[] args)
        {
            Task1Example();
            Task2Example();
        }
    }
}