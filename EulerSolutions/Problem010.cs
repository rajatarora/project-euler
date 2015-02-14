using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;

namespace EulerSolutions
{
    public class Problem010 : EulerBase
    {
        public string execute()
        {
            long sum = 2;
            for (int i = 3; i < 2000000; i += 2)
            {
                if (EulerHelpers.IsPrime(i)) sum += i;
            }
            return sum.ToString();
        }
    }
}
