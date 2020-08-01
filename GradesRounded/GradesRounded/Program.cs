using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesRounded
{
    class Program
    {
        //76 67 38 33
        //Convert to next multiple of 5
        private static int CharChange(int i)
        {
            char[] original = Convert.ToString(i).ToCharArray();
            if (original.Length != 2|| i == 0 || i % 10 == 0 || i % 5 ==0 ) return i;
            if(int.Parse(original[1].ToString()) < 5)
            {
                original[1] = '5';
                return int.Parse(string.Format("{0}{1}", original[0], original[1]));
            }
            else
            {
                int temp = int.Parse(original[0].ToString());
                temp++;
                original[1] = '0';
                return int.Parse(string.Format("{0}{1}", temp, original[1]));
            }
          
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            foreach(int i in grades)
            {
                int MultipleFive = CharChange(i);
                if ( (MultipleFive - i) < 3 && i >= 38)
                {
                    result.Add(MultipleFive);
                    continue;
                }
                result.Add(i);
            }
            return result;            
        }
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);
            Console.WriteLine("************Result****************");
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
