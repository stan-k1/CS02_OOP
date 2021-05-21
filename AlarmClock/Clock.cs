using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class Clock
    {
        public int Hour { get; set; }
        public int Min { get; set; }
        public TimeZone Zone { get; set; } = GMT;

        public static TimeZone GMT = new TimeZone { ZoneName = "Greenwich Mean Time", Diff = 0 };

        public Clock() { }

        public Clock (int hour, int min)
        {
            if (hour <= 24 && min <= 60)
            {
                Hour = hour;
                Min = min;
            }
            else Console.WriteLine("Could not create clock. Invalid parameters.");
        }

        public bool SetTime(int hour, int min)
        {
            if (hour <= 24 && min < 60)
            {
                Hour = hour;
                Min = min;
                Console.WriteLine("Hour set!");
                return true;
            }

            Console.WriteLine("Invalid hour!");
            return false;
        }

        public bool SetTime(string hour, string min) 
        {
            int intHour = int.Parse(hour);
            int intMin = int.Parse(min);

            if (intHour <= 24 && intMin < 60)
            {
                Hour = intHour;
                Min = intMin;
                Console.WriteLine("Hour set!");
                return true;
            }

            Console.WriteLine("Invalid hour!");
            return false;
        }
    }
}
