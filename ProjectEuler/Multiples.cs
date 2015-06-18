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
    }
}
