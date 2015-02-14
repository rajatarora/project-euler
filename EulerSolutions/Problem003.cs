using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;

namespace EulerSolutions
{
    public class Problem003 : EulerBase
    {
        public string execute()
        {
            long number = 600851475143;
            double sqrtNumber = Math.Sqrt(number);
            long largestPrimeFactor = 2;

            for (long i = 3; i <= sqrtNumber; i++)
            {
                if ((i % 2 != 0) && EulerHelpers.IsPrime(i) && (number % i == 0))
                {
                    largestPrimeFactor = i;
                }
            }

            return largestPrimeFactor.ToString();
        }
    }
}
