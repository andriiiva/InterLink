using System;
using System.Collections.Generic;
namespace InternshipTest.Schedule
{
	public class MonthSchedule : ISchedule
	{

        List <int> months = new List <int> ();

        public MonthSchedule(params int[] months) 
        {
            this.months.AddRange(months);
        }

        public bool isActiveDay(DateTime day)
        {
            return this.months.Contains(day.Month);
        }

    }
}
