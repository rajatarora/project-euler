using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;

namespace EulerSolutions
{
    public class Problem006 : EulerBase
    {
        public string execute()
        {
            return ((Math.Pow(Enumerable.Range(1, 100).Aggregate((a, b) => a + b), 2)) - (Enumerable.Range(1, 100).Select(a => Math.Pow(a, 2)).Aggregate((a, b) => a + b))).ToString();
        }
    }
}
