using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten
{
    class Program
    {
        static void Main(string[] args)
        {
            timeAndPlayerMap.fnTimeAndPalyerMap();

            List<List<int>> list = new List<List<int>> { new List<int> { 5, 2, 8 }, new List<int> { 3, 5, 14 }, new List<int> { 1, 16, 1 }, new List<int> { 3, 5, 1 }, new List<int> { 8, 2, 12 }, new List<int> { 16, 1, 1 }, new List<int> { 3, 3, 6 }, new List<int> { 2, 6, 12 }, new List<int> { 15, 1, 0 }, new List<int> { 5, 3, 7 }, new List<int> { 4, 3, 5 }, new List<int> { 3, 5, 11 }, new List<int> { 7, 2, 13 }, new List<int> { 15, 1, 6 }, new List<int> { 15, 1, 15 }, new List<int> { 4, 4, 9 }, new List<int> { 5, 3, 8 }, new List<int> { 3, 5, 6 }, new List<int> { 16, 1, 7 }, new List<int> { 1, 15, 7 }, new List<int> { 4, 3, 12 }, new List<int> { 5, 3, 13 }, new List<int> { 2, 4, 5 }, new List<int> { 5, 3, 5 }, new List<int> { 16, 1, 16 }, new List<int> { 2, 5, 8 }, new List<int> { 5, 3, 4 }, new List<int> { 5, 3, 10 }, new List<int> { 4, 4, 7 }, new List<int> { 3, 5, 9 }, new List<int> { 4, 2, 2 }, new List<int> { 4, 4, 15 }, new List<int> { 2, 2, 4 }, new List<int> { 5, 3, 11 }, new List<int> { 4, 4, 8 }, new List<int> { 1, 16, 9 }, new List<int> { 4, 4, 16 }, new List<int> { 1, 15, 6 }, new List<int> { 15, 1, 8 }, new List<int> { 5, 3, 6 }, new List<int> { 16, 1, 9 }, new List<int> { 3, 5, 15 }, new List<int> { 1, 15, 1 }, new List<int> { 1, 15, 0 }, new List<int> { 2, 5, 9 }, new List<int> { 3, 5, 10 }, new List<int> { 1, 15, 15 }, new List<int> { 3, 2, 0 }, new List<int> { 5, 3, 2 }, new List<int> { 5, 3, 1 }, new List<int> { 5, 2, 4 }, new List<int> { 3, 5, 4 }, new List<int> { 2, 7, 13 }, new List<int> { 3, 3, 0 }, new List<int> { 7, 2, 11 }, new List<int> { 4, 4, 0 }, new List<int> { 1, 1, 0 }, new List<int> { 2, 6, 9 }, new List<int> { 3, 5, 3 }, new List<int> { 5, 3, 15 }, new List<int> { 5, 2, 6 }, new List<int> { 3, 4, 12 }, new List<int> { 2, 3, 6 }, new List<int> { 1, 1, 1 }, new List<int> { 15, 1, 1 }, new List<int> { 1, 16, 16 }, new List<int> { 2, 2, 2 }, new List<int> { 3, 3, 9 }, new List<int> { 16, 1, 8 }, new List<int> { 9, 1, 6 }, new List<int> { 5, 3, 12 }, new List<int> { 2, 2, 3 }, new List<int> { 3, 5, 7 }, new List<int> { 7, 2, 0 }, new List<int> { 4, 3, 6 }, new List<int> { 2, 3, 4 }, new List<int> { 1, 15, 8 }, new List<int> { 16, 1, 0 }, new List<int> { 5, 3, 9 }, new List<int> { 15, 1, 7 }, new List<int> { 2, 4, 6 }, new List<int> { 1, 16, 7 }, new List<int> { 3, 5, 12 }, new List<int> { 1, 16, 8 }, new List<int> { 4, 4, 1 }, new List<int> { 3, 5, 0 }, new List<int> { 3, 5, 8 }, new List<int> { 1, 16, 0 }, new List<int> { 5, 3, 3 }, new List<int> { 5, 3, 0 }, new List<int> { 1, 13, 9 }, new List<int> { 3, 5, 2 }, new List<int> { 1, 9, 6 }, new List<int> { 6, 2, 12 }, new List<int> { 4, 3, 8 }, new List<int> { 3, 5, 5 }, new List<int> { 5, 3, 14 }, new List<int> { 4, 3, 7 }, new List<int> { 6, 2, 4 }, new List<int> { 3, 5, 1 } };
            int i = 0;
            foreach (var item in list)
            {
                i++;
                Console.Write("[" + item[0] + ", " + item[1] + ", " + item[2] + "]: ");
                LessNoisyMeetingRooms.fnLessNoisyMeetingRoomsExt(item[0], item[1], item[2]);

                if (i % 20 == 0)
                    Console.WriteLine("---------------------");
            }

            LessNoisyMeetingRooms.fnLessNoisyMeetingRoomsExt(4, 4, 9);

            Console.Read();
        }
    }
}
