using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
