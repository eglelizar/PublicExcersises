using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoom
{
    class Program
    {
        private static int[] time = new int[24];
        static int GetNumberOfMeetings(int[,] meetingUsed)
        {
            for(int i =0; i< (meetingUsed.Length/2)-1; i++)
            {
                for(int j=meetingUsed[i,0]; j< meetingUsed[i, 1]; j++)
                {
                    time[j] ++;
                }
            }
            return time.Select(x => x).Max();

        }
        static void Main(string[] args)
        {
            int[,] meetings = new int[8, 2] { { 8, 9 }, { 8, 10 }, { 8, 13 }, { 10, 11 }, { 10, 12 }, { 9, 10 } , { 9, 11 }, { 12, 13 } };
            Console.Write(GetNumberOfMeetings(meetings));
            Console.ReadKey();
        }
    }
}
