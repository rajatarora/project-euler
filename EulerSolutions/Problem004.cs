using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;

namespace EulerSolutions
{
    public class Problem004 : EulerBase
    {
        public string execute()
        {
            long result = 0;

            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    long product = i * j;
                    if (EulerHelpers.IsPalindrome(product.ToString()) && product > result)
                    {
                        result = product;
                    }
                }
            }
            return result.ToString();
        }
    }
}
