using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;

namespace EulerSolutions
{
    public class Problem001 : EulerBase
    {
        public string execute()
        {
            return Enumerable.Range(0, 1000).Where(a => a % 3 == 0 || a % 5 == 0).Aggregate((a, b) => a + b).ToString();
        }
    }
}
