using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquare
{
    class Program
    {
        static int formingMagicSquare(int[][] s)
        {

            int[,] s1 = new int[,] { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } };
            int[,] s2 = new int[,] { { 6, 1, 8 }, { 7, 5, 3 }, { 2, 9, 4 } };
            int[,] s3 = new int[,] { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } };
            int[,] s4 = new int[,] { { 2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 } };
            int[,] s5 = new int[,] { { 8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 } };
            int[,] s6 = new int[,] { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } };
            int[,] s7 = new int[,] { { 6, 7, 2 }, { 1, 5, 9 }, { 8, 3, 4 } };
            int[,] s8 = new int[,] { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } };
            int minCost = evaluateMatrix(s, s1, int.MaxValue);
            minCost = evaluateMatrix(s, s2, minCost);
            minCost = evaluateMatrix(s, s3, minCost);
            minCost = evaluateMatrix(s, s4, minCost);
            minCost = evaluateMatrix(s, s5, minCost);
            minCost = evaluateMatrix(s, s6, minCost);
            minCost = evaluateMatrix(s, s7, minCost);
            minCost = evaluateMatrix(s, s8, minCost);
            return minCost;
        }
        static int evaluateMatrix(int [][] original, int [,] s1, int currentCost)
        {
            int cost = 0;
            for (int i = 0; i < 3; i++)
                for (int j =0; j<3; j++)
                {
                    cost += Math.Abs(s1[i, j] - original[i][j]);
                }
            return currentCost > cost ? cost: currentCost;
        }
        static void Main(string[] args)
        {
            int[][] s = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }

            int result = formingMagicSquare(s);
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
