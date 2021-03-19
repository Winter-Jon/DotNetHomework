using System;
using System.Timers;

namespace problem2
{
    class Program
    {

        public class Clock
        {
            private int alarmTime;
            private int curTime;

            public delegate void TickHandle();
            public delegate void AlarmHandle();
            public event TickHandle TickEvent;
            public event AlarmHandle AlarmEvent;

            public void TickLog()
            {
                Console.WriteLine("Tick!");
            }

            public void AlarmLog()
            {
                Console.WriteLine("Alarm!");
            }

            public Clock()
            {
                TickEvent = TickLog;
                AlarmEvent = AlarmLog;
                Tick();
                Alarm();
            }

            public void setAlarmTime(int t)
            {
                alarmTime = t;
            }

            private void Tick()
            {
                TickEvent();
                curTime += 1;
                System.Threading.Thread.Sleep(1000);
            }

            private void Alarm()
            {
                if (curTime == alarmTime)
                    AlarmEvent();
            }

            public void Start()
            {
                while(true)
                {
                    Tick();
                    Alarm();
                }
            }
        }

        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.setAlarmTime(15);

            clock.Start();
        }
    }
}
