using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeMessage
{
    class Program
    {


        //private static int DecoderRecursive(string str, int index, int length, int sum)
        //{
        //    if (index + length > str.Length) return 0;
        //    int toEvaluate = int.Parsñe(str.Substring(index, length));           
        //    if (toEvaluate >= 1 && toEvaluate <= 26)
        //    {
        //        if(index + length == str.Length){
        //            return 1;
        //        }
        //        sum += DecoderRecursive(str, index+1,  length, sum) ;
        //    }
        //    else
        //        return 0;

        //    return sum;


        private static int Decoder(string strToDecode)
        {
            int?[] memoization = new int?[strToDecode.Length + 1];
            if (strToDecode.Length < 2) return 1;
            int Decode1 = int.Parse(strToDecode.Substring(0, 1));
            int Decode2 = int.Parse(strToDecode.Substring(0, 2));
            if (Decode1 == 0 || Decode2 ==0)
                return 0;
            return DecoderRecursive(strToDecode, Decode1, 1, memoization) + DecoderRecursive(strToDecode, Decode2, 2, memoization);
        }
        private static int DecoderRecursive(string original, int Decoder, int index, int?[] memo)
        {
            if (Decoder == 0 || Decoder > 26)
                return 0;
            if (index == original.Length)
                return 1;
            if (memo[index].HasValue)
            {
                return memo[index].Value;
            }
            int Decode1 = int.Parse(original.ToString().Substring(index, 1));
            int sum = DecoderRecursive(original, Decode1, index + 1, memo);
            if (index + 2 <= original.Length)
            {
                int Decode2 = int.Parse(original.ToString().Substring(index, 2));
                sum += DecoderRecursive(original, Decode2, index + 2, memo);
            }
            memo[index] = sum;
            return sum;
        }

        //array 123
        //1,2,3
        //12,3
        //1,23
        //public static int DecoderRecursive(string str)
        //{
        //    return DecoderRecursive(str, 0,0);
        //}
        //private static int DecoderRecursive(string str, int index, int sum)
        //{
        //    if (index > str.Length) return 0;
        //    if (index == str.Length)
        //        return 1;

        //    //Evaluate string  with length 1
        //    if (index + 1 <= str.Length)
        //    {
        //        int toEvaluate1 = int.Parse(str.Substring(index, 1));
        //        if (toEvaluate1 == 0)
        //            return 0;
        //        sum += DecoderRecursive(str, index + 1, sum);
        //    }
        //    //Evaluate string  with length 2
        //    if (index + 2 <= str.Length)
        //    {
        //        int toEvaluate2 = int.Parse(str.Substring(index, 2));
        //        if (toEvaluate2 > 26)
        //            return 0;
        //        sum += DecoderRecursive(str, index + 2, sum);
        //    }
        //    return sum;
        //}


        //}
        //public static int Decoder (string original)
        //{
        //    return DecoderRecursive(original, 0,1) + DecoderRecursive(original, 0, 2);
        //}

        //private static int DecoderRecursive(string str,  int index, int length)
        //{           
        //    if (index > str.Length) return 0;
        //    if (index == str.Length)
        //        return 1;
        //    int EvaluateStr = int.Parse(str.Substring(index, length));
        //    if (EvaluateStr == 0 || EvaluateStr > 27) return 0;

        //    int sum = DecoderRecursive(str, index+1, 1);
        //    if (index + 2 <= str.Length)
        //    {
        //        sum += DecoderRecursive(str, index + 1, 2);
        //    }
        //    return sum;

        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string cad = Console.ReadLine();
            Console.WriteLine(Decoder(cad));
            Console.ReadLine();
        }
    }
}
