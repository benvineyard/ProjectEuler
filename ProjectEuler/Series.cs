using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Series
    {
        public static double DifferenceSumOfSquaresAndSquaredSum(int start, int end)
        {
            return Math.Pow(CalculateSum(start, end), 2) - Squares.GetSum(start, end);
        }

        private static long CalculateSum(int start, int end)
        {
            long sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
