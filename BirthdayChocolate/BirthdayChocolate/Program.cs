using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {

            return birthday(s, d, m, 0, 0);
        }

        private static int birthday(List<int> s, int sum, int num, int index, int _ways)
        {
            int ways = 0;
            //if (index + num > s.Count)
            //{
            //    return 0;
            //}
            while (index + num <= s.Count)
            {
                int local = 0;
                for (int i=0; i<num; i++)
                {
                    local += s[index+i];
                }
                if (local == sum)
                {
                    ways++;
                }
                index++;
                //ways +=birthday(s, sum, num, index++, ways);
            }
            return ways;
            
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(string.Format("result: {0}", result));

            Console.ReadLine();
        }
    }
}
