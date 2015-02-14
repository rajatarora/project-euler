using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;

namespace EulerSolutions
{
    public class Problem002 : EulerBase
    {
        public string execute()
        {
            List<long> fibonacciSequence = EulerHelpers.FibonacciSequence(4000000);
            long sum = 0;

            foreach (long value in fibonacciSequence)
            {
                if (value % 2 == 0) sum += value;
            }
            return sum.ToString();
        }
    }
}
