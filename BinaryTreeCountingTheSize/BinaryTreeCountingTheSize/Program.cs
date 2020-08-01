using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeCountingTheSize
{
    class Program
    {
        public static string ReturnMoreSize(int[] nodes)
        {
            int left = SumChildNodes(nodes, 1);
            int right = SumChildNodes(nodes, 2);
            return left > right? "left": left < right ? "right" : "";
        }
        private static int GetIndexChildLeft(int index)
        {
            return (index * 2 ) +1;
        }
        private static int GetIndexChildRight(int index)
        {
            return (index * 2) +2;
        }
        private static int SumChildNodes(int[]nodes, int index)
        {
            if (index >= nodes.Length) return 0;
            if (nodes[index] < -1 ) return 0;
            int sum = nodes[index];
            sum += SumChildNodes(nodes, GetIndexChildLeft(index)) + SumChildNodes(nodes, GetIndexChildRight(index));
            return sum; 
        }

        static void Main(string[] args)
        {

            //[3,6,9, -1,4,1,-1,8]
            string array = Console.ReadLine();
            int[] values = array.Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            Console.WriteLine(ReturnMoreSize(values));
            Console.ReadKey();

        }
    }
}
