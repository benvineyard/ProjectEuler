﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem2
    {
        public static int EvenFibonacciNumbersSum()
        {
            int sum = 0;
            int nthFibonacci = 0;

            for (int i = 1; i < 4000000; i++)
            {
                nthFibonacci = GetNthFibonacci(i);

                if (nthFibonacci > 4000000)
                    break;

                if (nthFibonacci % 2 == 0)
                    sum += nthFibonacci;
            }

            return sum;
        }

        private static int GetNthFibonacci(int n)
        {
            if (n <= 1)
                return 1;

            return GetNthFibonacci(n - 1) + GetNthFibonacci(n - 2);
        }
    }
}
