using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;

namespace EulerSolutions
{
    public class Problem009 : EulerBase
    {
        public string execute()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    int c = 1000 - a - b;
                    if (EulerHelpers.IsPythagoreanTriplet(a, b, c))
                    {
                        return (a * b * c).ToString();
                    }
                }
            }
            return "0";
        }
    }
}
