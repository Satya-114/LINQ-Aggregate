using System;
using System.Linq;

namespace LINQ_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            //Using Method Syntax
            var MSAverageValue = intNumbers.Average();
            //Using Query Syntax
            var QSAverageValue = (from num in intNumbers
                                  select num).Average();
            Console.WriteLine("Average Value = " + MSAverageValue);
            Console.ReadKey();
        }
    }
}
