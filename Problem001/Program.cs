using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem001
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Enumerable.Range(1, 1000).Where(a => a % 3 == 0 || a % 5 == 0).Aggregate((a, b) => a + b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
