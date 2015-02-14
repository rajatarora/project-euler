using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;

namespace EulerSolutions
{
    public class Problem005 : EulerBase
    {
        public string execute()
        {
            int result = 0;
            for (int i = 20; true; i += 20)
            {
                bool found = true;
                for (int j = 19; j > 2; j--)
                {
                    if (i % j != 0)
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    result = i;
                    break;
                }
            }
            return result.ToString();
        }
    }
}
