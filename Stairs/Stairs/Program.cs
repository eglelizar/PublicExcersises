using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stairs
{
    class Program
    {
        public static HashSet<string> CalculateCombinations(int [] array, int stairsLength)
        {
            HashSet<string> hash = new HashSet<string>();
            return CalculateCombinations(array, "0 ", stairsLength,  0, 0, hash);
        }
        //array[1 2]
        //stairsLength = 4
        //ParentRoute  1
        //index 0
        private static HashSet<string> CalculateCombinations(int[] array, string ParentRoute, int stairsLength, int index, int sum, HashSet<string> _hash)
        {
            if (index >= array.Length) return null;
          
            //Exact combination

            while (sum < stairsLength && index < array.Length)
            {
                sum += array[index];
                ParentRoute += String.Format("{0} ",sum);
                CalculateCombinations(array, ParentRoute, stairsLength, index, sum, _hash);
                index++;
            }

            if (sum == stairsLength)
            {
                _hash.Add(ParentRoute);                
            }
            return _hash;
        }

        //[1 2]
        static void Main(string[] args)
        {
            int stairsLength = int.Parse(Console.ReadLine());
            string value = Console.ReadLine();
            int[] array = value.Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            Console.WriteLine("Results:************************");
            foreach(string a in CalculateCombinations(array, stairsLength))
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
