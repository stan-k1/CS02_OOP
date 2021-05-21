using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Stopwatch : AlarmClock
    {
        private Random random = new Random();

        public void Start()
        {
            Console.WriteLine("Count has started!");
        }

        public void Stop()
        {
            Console.WriteLine($"Count has stopped {random.Next().ToString()}");
        }

        public Stopwatch(int hour, int min, int alarmHour, int alarmMin, string alarmMsg) 
            : base(hour, min, alarmHour, alarmMin, alarmMsg)
        {

        }

        public Stopwatch(int hour, int min, int alarmHour, int alarmMin)
                : base(hour, min, alarmHour, alarmMin)
        {

        }
    }
}
