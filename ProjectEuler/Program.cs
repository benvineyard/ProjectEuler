using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine(string.Format("Problem #1: {0}", Problem1.Answer()));
            Console.WriteLine(string.Format("Problem #2: {0}", Problem2.EvenFibonacciNumbersSum()));
            Console.WriteLine(string.Format("Problem #2: {0}", Problem3.GetLargestPrimeFactor()));

            Console.ReadKey();
        }
    }
}
