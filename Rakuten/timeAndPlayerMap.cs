using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten
{
    class timeAndPlayerMap
    {
        public static void fnTimeAndPalyerMap()
        {
            var players = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> timeAndPlayerMap = new Dictionary<int, int>();
            int singleMatchCount = 0;
            int doubleMatchCount = 0;
            for (int i = 0; i < players; i++)
            {
                int[] playerTime = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), int.Parse);
                for (int j = playerTime[0] + 1; j <= playerTime[1]; j++)
                {
                    if (!timeAndPlayerMap.ContainsKey(j))
                    {
                        timeAndPlayerMap.Add(j, 1);
                    }
                    else
                    {
                        timeAndPlayerMap[j]++;
                    }
                }
            }

            foreach (var item in timeAndPlayerMap)
            {
                if (item.Value >= 2 && item.Value <= 3)
                    singleMatchCount++;
                else if (item.Value > 3)
                    doubleMatchCount++;
                else
                    continue;
            }

            Console.WriteLine(singleMatchCount + " " + doubleMatchCount);
        }
    }
}
