using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Factorial
    {
        public static BigInteger Calculate(int n)
        {
            BigInteger result = 1;

            for (long i = 2; i <= n; i++)
                result *= i;

            return result;
        }
    }
}
