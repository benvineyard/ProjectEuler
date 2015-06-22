using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Squares
    {
        public static double GetSum(int rangeStart, int rangeEnd)
        {
            double sum = 0;

            for (int i = rangeStart; i <= rangeEnd; i++)
			{
                sum += Math.Pow(i, 2);     
			}

            return sum;
        }
    }
}
