using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloomsburg_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mileSec = 0;
            int mileMin = 0;
            int lapTimeSec = 0;
            int lapTimeMin = 0;
            int Mile = 1609;

            Console.Write("Interval distance in meters: ");
            int[] distance = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();

            Console.Write("Target mile pace: ");
            int[] RunTime = Console.ReadLine().Split(':').Select(i => Convert.ToInt32(i)).ToArray();

            mileMin = RunTime[0];
            mileSec = RunTime[1];

            int Pace = (mileMin * 60) + mileSec;

            int Time = (distance[0] * Pace) / Mile;

            lapTimeMin = Time / 60;
            lapTimeSec = Time % 60;

            if (lapTimeSec < 10)
            {
                Console.WriteLine("Time for each interval: " + lapTimeMin + ":0" + lapTimeSec);
            }

            if (lapTimeMin > 60)
            {
                int lapTimeHour = Time / 60;
                Console.WriteLine("Time for each interval: " + (lapTimeHour / 60) + ":" + (lapTimeMin / 12) + ":" + lapTimeSec);
            }

            else
            Console.WriteLine("Time for each interval: " + lapTimeMin +":" + lapTimeSec);
        }
    }
}
