using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem002
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> sequence = new List<long>() { 1, 1 };
            long sum = 0;

            for (int i = 2; ; i++)
            {
                sequence.Add(sequence[i - 2] + sequence[i - 1]);
                if (sequence[i] > 4000000) break;
                if (sequence[i] % 2 == 0) sum += sequence[i]; 
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
