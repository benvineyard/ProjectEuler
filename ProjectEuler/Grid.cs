using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Grid
    {
        public static long GetLargestProductInGrid(int[][] grid)
        {
            long currentGreatestProduct = 0;
            long prod = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j < 17)
                    {
                        prod = grid[i][j] * grid[i][j + 1] * grid[i][j + 2] * grid[i][j + 3];
                    }

                    if (prod > currentGreatestProduct)
                    {
                        currentGreatestProduct = prod;
                    }

                    if (i < 17)
                    {
                        prod = grid[i][j] * grid[i + 1][j] * grid[i + 2][j] * grid[i + 3][j];
                    }

                    if (prod > currentGreatestProduct)
                    {
                        currentGreatestProduct = prod;
                    }

                    if (i < 17 && j < 17)
                    {
                        prod = grid[i][j] * grid[i + 1][j + 1] * grid[i + 2][j + 2] * grid[i + 3][j + 3];
                    }

                    if (prod > currentGreatestProduct)
                    {
                        currentGreatestProduct = prod;
                    }

                    if (i < 17 && j > 2)
                    {
                        prod = grid[i][j] * grid[i + 1][j - 1] * grid[i + 2][j - 2] * grid[i + 3][j - 3];
                    }

                    if (prod > currentGreatestProduct)
                    {
                        currentGreatestProduct = prod;
                    }
                }
            }
            return currentGreatestProduct;
        }

        /// <summary>
        /// Starting in the top left corner of a 2×2 grid, and 
        /// only being able to move to the right and down, there 
        /// are exactly 6 routes to the bottom right corner.
        /// </summary>
        /// <seealso cref="https://projecteuler.net/problem=15"/>
        /// <param name="squareGridWidth">Grid width, default is 20X20</param>
        /// <returns>The number of paths from the top left to bottom right of grid.</returns>
        public static BigInteger GetNumTopLeftToBottomRightPaths(int squareGridWidth = 20)
        {
            BigInteger factSize = Factorial.Calculate(squareGridWidth);
            BigInteger comb = Factorial.Calculate(squareGridWidth * 2) / (factSize * factSize);
            return comb;
        }
    }
}
