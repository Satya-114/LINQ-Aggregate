using System;
using System.Linq;

namespace LINQ_Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] skills = { "C#.NET", "MVC", "WCF", "SQL", "LINQ", "ASP.NET" };
            string result = string.Empty;
            foreach (string skill in skills)
            {
                result = result + skill + ", ";
            }
            //Find the index position of last comma
            int lastIndex = result.LastIndexOf(",");
            //Remove the last comma
            result = result.Remove(lastIndex);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
