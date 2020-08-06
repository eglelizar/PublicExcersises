using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoArraysGivesTheSumTarget
{
    class Program
    {
        private static int[,] result = new int[2, 3];
        private static int resultindex = 0;
        private static void InsertValues(int a, int b, int target, int index)
        {
            result[index, 0] = a;
            result[index, 1] = b;
            result[index, 2] = target - a - b;
            resultindex++;
        }
        private static int GetIndexWithMaxDifference()
        {
            if (resultindex == 0 || resultindex == 1) return resultindex;
            if (Math.Abs(result[0, 2]) > Math.Abs(result[1, 2]))
                return 0;
            return 1;
        }
        private static int GetDifference(int index)
        {
            if (resultindex == 0) return 0;
            return result[index, 2];
        }
        private static void EvaluateToStore(int a, int b, int target)
        {
            int difference = target - a - b;
            if (resultindex < 2)
            {
                InsertValues(a, b, target, resultindex);
            }
            int maxIndex = GetIndexWithMaxDifference();
            int currentMaxDiff = GetDifference(maxIndex);
            if (Math.Abs(currentMaxDiff) > Math.Abs(difference) && resultindex > 1)
            {
                InsertValues(a, b, target, maxIndex);
            }

        }
        public static int[,]  GetValuesSum(int[] array1, int [] array2, int target)
        {
            //1. Get the complement 24-(-1) = 25
            int sum = 0;
            for (int i= 0; i < array1.Length; i++)
                for (int j = 0; j< array2.Length; j++)
                {                    
                    EvaluateToStore(array1[i], array2[j], target);
                }
            return result;
        }
        //24
        //array1 -1,3,8,2,9,5 - O(n2)
        //array2 4,1,2,10,5,20
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int[] array1 = str.Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            str = Console.ReadLine();
            int[] array2 = str.Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int[,] result = GetValuesSum(array1, array2, target);
            for(int i = 0; i <2; i++)
            {
                Console.WriteLine(string.Format("({0} {1})", result[i, 0], result[i, 1]));
            }
            Console.ReadKey();
        }
    }
}
