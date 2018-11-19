using System;
using System.Collections.Generic;
namespace InternshipTest.Schedule
{
	public class DoWSchedule : ISchedule
	{

        List <DayOfWeek> days = new List <DayOfWeek> ();

        public DoWSchedule(params DayOfWeek[] days) 
        {
            this.days.AddRange(days);
        }

        public bool isActiveDay(DateTime day)
        {
            return days.Contains(day.DayOfWeek);
        }

    }
}
