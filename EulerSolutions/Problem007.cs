using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;

namespace EulerSolutions
{
    public class Problem007 : EulerBase
    {
        public string execute()
        {
            int count = 1;
            for (long i = 3; true; i += 2)
            {
                if (EulerHelpers.IsPrime(i))
                {
                    count++;
                    if (count == 10001) return i.ToString();
                }
            }
        }
    }
}
