using System;
using System.Collections.Generic;
namespace InternshipTest.Schedule
{
	public class LastWoMSchedule : ISchedule
	{

        List <DayOfWeek> days = new List <DayOfWeek> ();

        public LastWoMSchedule(params DayOfWeek[] days) 
        {
            this.days.AddRange(days);
        }

        public bool isActiveDay(DateTime day)
        {
            DateTime last = new DateTime(day.Year, day.Month, DateTime.DaysInMonth(day.Year, day.Month));
            List <DateTime> days = new List<DateTime>();
            for(int i = 0; i < 7; i++){
                days.Add(last.AddDays(-i));
            }
            foreach (DateTime d in days){
                if (this.days.Contains(d.DayOfWeek)){
                    return true;
                }
            }
            return false;
        }

    }
}
