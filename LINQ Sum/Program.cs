using System;
using System.Linq;


namespace LINQ_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };
            //Using Method Syntax
            int MSTotal = intNumbers.Sum();
            //Using Query Syntax
            int QSTotal = (from num in intNumbers
                           select num).Sum();
            Console.WriteLine("Sum = " + QSTotal);
            Console.ReadKey();
        }
    }
}
