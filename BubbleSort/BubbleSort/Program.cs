using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        public static void bubblesort (int[] array)
        {
            bool hasSwap = true;
            for (int j = 0; j < array.Length && hasSwap; j++)
            {
                hasSwap = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        SwapElements(array, i, i + 1);
                        hasSwap = true;
                    }
                }
            }
        }
        public static void SwapElements(int[]array, int i, int j)
        {
            int aux = array[i];
            array[i] = array[j];
            array[j] = aux;
        }
        static void Main(string[] args)
        {
            string initialValues = Console.ReadLine();
            int [] elements = initialValues.Split(' ').ToList().Select(x=>Convert.ToInt32(x)).ToArray<int>();
            bubblesort(elements);
            for (int a= 0; a < elements.Length; a++){
                Console.WriteLine(" "+ elements[a]);
            }
            Console.ReadLine();

        }
    }
}
