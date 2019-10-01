using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class linqq
    {
        static void Main(string[] args)
        {
            string[] names = { "Sachin", "Mani", "Sahara", "Sohan", "Naveen" };

            var shortName = from s in names
                            where s.StartsWith("S")
                            select s;

            foreach (var item in shortName)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
