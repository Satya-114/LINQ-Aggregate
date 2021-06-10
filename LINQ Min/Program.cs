using System;
using System.Linq;

namespace LINQ_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            //Using Method Syntax
            int MSLowestNumber = intNumbers.Min();
            //Using Query Syntax
            int QSLowestNumber = (from num in intNumbers
                                  select num).Min();
            Console.WriteLine("Lowest Number = " + MSLowestNumber);
            Console.ReadKey();
        }
    }
}
