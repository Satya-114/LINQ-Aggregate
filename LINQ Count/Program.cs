using System;
using System.Linq;
   

namespace LINQ_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            //Using Method Syntax
            int MSCount = intNumbers.Count();
            //Using Query Syntax
            var QSCount = (from num in intNumbers
                           select num).Count();
            Console.WriteLine("No of Elements = " + MSCount);
            Console.ReadKey();
        }
    }
}
