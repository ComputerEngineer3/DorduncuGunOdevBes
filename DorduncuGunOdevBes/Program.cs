using System;
using System.Collections.Generic;

namespace DorduncuGunOdevBes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, int> myDictionary1 = new MyDictionary<int, int>();
            myDictionary1.Add(1, 10);
            myDictionary1.Add(2, 20);
            myDictionary1.Add(3, 30);

            Console.WriteLine("-----myDictionary1-----");
            //Number of element:
            Console.WriteLine("Number of element: " + myDictionary1.Length);

            Console.WriteLine();

            //Listing Keys
            foreach (var item in myDictionary1.Keys)
            {
                Console.WriteLine("Keys: " + item);
            }

            Console.WriteLine();

            //Listing Values
            foreach (var item in myDictionary1.Values)
            {
                Console.WriteLine("Values: " + item);
            }

            Console.WriteLine();

            //Listing Keys And Values
            myDictionary1.Listing();

            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("-----myDictionary2-----");

            MyDictionary<int, string> myDictionary2 = new MyDictionary<int, string>();
            myDictionary2.Add(1, "one");
            myDictionary2.Add(2, "two");
            myDictionary2.Add(3, "three");
            myDictionary2.Add(4, "four");

            //Number of element:
            Console.WriteLine("Number of element: " + myDictionary2.Length);

            Console.WriteLine();

            //Listing Keys
            foreach (var item in myDictionary2.Keys)
            {
                Console.WriteLine("Keys: " + item);
            }

            Console.WriteLine();

            //Listing Values
            foreach (var item in myDictionary2.Values)
            {
                Console.WriteLine("Values: " + item);
            }

            Console.WriteLine();

            //Listing Keys And Values
            myDictionary2.Listing();

            Console.WriteLine("----------------------------------------------------------------------");
        }
    }
}
