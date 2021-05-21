using System;
using System.Collections.Generic;
using System.Text;

namespace Clock
{
    class AlarmClock : Clock
    {
        public int AlarmHour { get; set; }
        public int AlarmMin { get; set; }
        public string AlarmMsg { get; set; }

        public AlarmClock(int hour, int min, int alarmHour, int alarmMin, string alarmMsg) : base (hour, min)
        {

            if (alarmHour <= 24 && alarmMin <= 60)
            {
                AlarmHour = alarmHour;
                AlarmMin = alarmMin;
                AlarmMsg = alarmMsg;
            }

            else Console.WriteLine("Could not create alarm clock. Invalid parameters.");
        }

        public AlarmClock(int hour, int min, int alarmHour, int alarmMin) : base(hour, min)
        {

            if (alarmHour <= 24 && alarmMin <= 60)
            {
                AlarmHour = alarmHour;
                AlarmMin = alarmMin;
                AlarmMsg = "Ring!";
            }

            else Console.WriteLine("Could not create alarm clock. Invalid parameters.");
        }

        public AlarmClock() { };

        public bool SetAlarm(int hour, int min, string alarmMsg)
        {
            if (hour <= 24 && min <= 60)
            {
                hour = Hour;
                min = Min;
                AlarmMsg = alarmMsg;
                return true;
            }

            Console.WriteLine("Alarm could not be set. Invalid parameters.");
            return false;
        }

        public bool SetAlarm(int hour, int min)
        {
            if (hour <= 24 && min <= 60)
            {
                hour = Hour;
                min = Min;
                AlarmMsg = "Ring!";
                return true;
            }

            Console.WriteLine("Alarm could not be set. Invalid parameters.");
            return false;
        }
    }
}
