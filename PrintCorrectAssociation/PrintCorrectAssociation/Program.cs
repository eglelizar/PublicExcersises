using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCorrectAssociation
{
    class Program
    {
        private static string GetRightString(string str)
        {
            char[] result = new char[str.Length];
            char[] cad = str.ToArray<char>();
            Stack<int> stack = new Stack<int>(str.Length);
            for(int i=0; i <str.Length; i++)
            {
                if (cad[i] == '(')
                {
                    stack.Push(i);
                }
                else if(stack.Count > 0) {
                    result[stack.Pop()] = '(';
                    result[i] = ')';
                } 
            }
            return new string(result);
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(GetRightString(str));
            Console.ReadKey();
        }
    }
}
