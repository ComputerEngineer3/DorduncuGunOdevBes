using System;

namespace DorduncuGunOdevBes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDictionary<int, int> myDictionary1 = new MyDictionary<int, int>();
            myDictionary1.Add(1, 2);
            myDictionary1.Add(3, 4);
            myDictionary1.Add(5, 6);

            MyDictionary<int, string> myDictionary2 = new MyDictionary<int, string>();
            myDictionary2.Add(1, "one");
            myDictionary2.Add(2, "two");
            myDictionary2.Add(3, "three");
        }
    }
}
