using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// Utility class with methods for calculating and/or related to the Pythagorean theorem.
    /// <see cref="https://en.wikipedia.org/?title=Pythagorean_theorem"/>
    /// </summary>
    public class Pythagorean
    {
        public static int GetPythagoreanTripletProductForProvidedSum(int sum)
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    for (int c = 0; c < 1000; c++)
                    {
                        if (IsPythagoreanTriplet(a, b, c) && a + b + c == sum)
                            return a * b * c;        
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        /// a^2 + b^2 = c^2 (Pythagorean theorem)
        /// <example>
        /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        /// </example>
        /// </summary>
        /// <param name="a">Represents "a" in a^2 + b^2 = c^2 (Pythagorean theorem)</param>
        /// <param name="b">Represents "b" in a^2 + b^2 = c^2 (Pythagorean theorem)</param>
        /// <param name="c">Represents "c" in a^2 + b^2 = c^2 (Pythagorean theorem)</param>
        /// <returns>True if the triplet is a Pythagorean triplet, else false.</returns>
        private static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            if (a < b && b < c && (Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
                return true;

            return false;
        }
    }
}
