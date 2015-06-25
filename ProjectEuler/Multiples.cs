using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Multiples
    {
        public static int CalculateSum(int firstMultiple, int secondMultiple, int threshold)
        {
            int sum = 0;

            for (int i = 0; i < threshold; i++)
            {
                if (i % firstMultiple == 0 || i % secondMultiple == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int SmallestEvenlyDivisibleByAllFromXtoY(int rangeStart, int rangeEnd)
        {
            for (int i = rangeEnd + 1; i < int.MaxValue; i++)
            {
                bool divisible = true;

                for (int j = 2; j < rangeEnd; j++)
                {
                    if (i % j != 0)
                    {
                        divisible = false;
                        break;
                    }
                }
                if (divisible) return i;
            }
            return -1;
        }

        public static long GetNumberOfDivisors(long a)
        {
            long count = 1, k = 0, i;
            if (a == 1 || a == 2)
                return a;
            while ((a & 1) == 0)
            {
                k++;
                a >>= 1;
            }
            if (a == 1)
                return k + 1;
            else
                count = k + 1;
            for (i = 3; i * i <= a; i += 2)
            {
                k = 0;
                while (a % i == 0)
                {
                    k++;
                    a /= i;
                }
                count *= (k + 1);
            }
            if (a > 1)
                count <<= 1;
            return count;
        }
    }
}
