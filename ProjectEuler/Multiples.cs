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
    }
}
