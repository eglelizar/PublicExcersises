using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climbing_the_Leaderboard
{
    class Program
    {
        static List<int> myscores;
        private static int retrieveRankingFirstTime(int[] scores, int aliceScore)
        {
            myscores = new List<int>();
            long ind = 0;
            myscores.Add(scores[0]);
            while (ind < scores.Length-1 && aliceScore < scores[ind + 1])
            {
                if (scores[ind] != scores[ind + 1])
                {
                    myscores.Add(scores[ind+1]);
                }
                ind++;
            }
            if (scores.Length >1)
                myscores.Add(aliceScore);
            return myscores.Count();
        }
        private static int retrieveRankingSecondTimes(int lastIndex, int aliceScore)
        {
            int ind = lastIndex;
            while (ind > 0 && myscores[ind-1] <= aliceScore)
            {
                ind--;
            }
            return ind+1;
            
        }
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int[] result = new int[alice.Length];            
            for (int i=0; i<alice.Count(); i++)
            {
                if (i == 0)
                {
                    result[i] = retrieveRankingFirstTime(scores, alice[i]);
                }
                else
                {
                    result[i] = retrieveRankingSecondTimes(result[i-1]-1, alice[i]);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            StreamReader textWriter = new StreamReader("C:\\Users\\elizabeth.razo\\Desktop\\input01.txt", true);

            //int scoresCount = textWriter.ReadLine();
            int scoresCount = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int aliceCount = Convert.ToInt32(Console.ReadLine());

            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
            ;
            int[] result = climbingLeaderboard(scores, alice);

            foreach (int i in result)
                Console.WriteLine(i);
            Console.ReadLine();
            //textWriter.WriteLine(string.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();


        }
    }
}
