using System;
using InternshipTest.Schedule;

namespace InternshipTest.Schedule
{
    internal class JoinSchedule : ISchedule
    {
        private ISchedule a;
        private ISchedule b;

        public JoinSchedule(ISchedule a, ISchedule b)
        {
            this.a = a;
            this.b = b;
        }

        public bool isActiveDay(DateTime day)
        {
            return a.isActiveDay(day) && b.isActiveDay(day);
        }
    }
}