using System;
using System.Linq;

namespace LINQ_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 10, 80, 50, 90, 60, 30, 70, 40, 20, 100 };
            //Using Method Syntax
            int MSLergestNumber = intNumbers.Max();
            //Using Query Syntax
            int QSLergestNumber = (from num in intNumbers
                                   select num).Max();
            Console.WriteLine("Largest Number = " + MSLergestNumber);
            Console.ReadKey();
        }
    }
}
