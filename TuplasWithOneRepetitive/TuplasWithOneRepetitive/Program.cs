using System;
using System.Collections.Generic;
using System.Linq;

namespace TuplasWithOneRepetitive
{
    class Program
    {
        public static int NumberOfValidTuples(int [] array)
        {
            int sum = 0;
            for (int i=0; i<array.Length; i++)
                sum += NumberOfValidTuples(array, new Dictionary<int, int>(), i);
            return sum;
        }
        // 1 1 2 3 5
        public static int NumberOfValidTuples(int[] array, Dictionary<int, int> evaluatedSolutions, int index)
        {
            if (evaluatedSolutions.Count() == 2)

            {
                var value = evaluatedSolutions.Where(x => x.Value == 2);
                if (value.Count() > 0)
                {
                    Console.WriteLine(string.Join(" ", evaluatedSolutions));
                    return 1;
                }
            }
            if (index >= array.Length || evaluatedSolutions.Count() >2 )
            {
                return 0;
            }

            //Search into evaluatedSolutions if this is already there but just 1 time
            bool found = evaluatedSolutions.ContainsKey(array[index]);
            if (found)
            {
                evaluatedSolutions[array[index]]++;
            }
            else
            {
                evaluatedSolutions.Add(array[index], 1);
            }
            return NumberOfValidTuples(array, evaluatedSolutions, index + 1);
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 0, 1, 2, 1 };
            Console.WriteLine(NumberOfValidTuples(array));
            Console.ReadKey();
            Dictionary<int, string> isIN = new Dictionary<int, string>();
            if (isIN.ContainsKey(s))
        }
    }
}
