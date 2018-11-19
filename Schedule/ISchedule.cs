using System;
namespace InternshipTest.Schedule
{
	public interface ISchedule
	{
        bool isActiveDay(DateTime day);
    }
}
