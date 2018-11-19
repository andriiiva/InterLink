using InternshipTest.KnowledgeSource;
using InternshipTest.Schedule;
using InternshipTest.Person;

using System;

namespace InternshipTest.Education
{
	public class Task
	{
		public IKnowledgeSource source;
		public ISchedule schednle;
		public Period period = new Period();
		public Task (IKnowledgeSource source, ISchedule schednle)
		{
			this.period = null;
			this.source = source;
			this.schednle = schednle;
		}
		public Task (IKnowledgeSource source, Period period, ISchedule schednle)
		{
			this.period = period;
			this.source = source;
			this.schednle = schednle;
		}
		public Task (Period period, ISchedule schednle)
		{
			this.period = period;
			this.source = null;
			this.schednle = schednle;
		}
        public bool isActiveDay(DateTime date)
		{
			bool inPeriod = period?.includes(date) ?? true;
            return inPeriod && schednle.isActiveDay(date);
        }

		public void apply(Student student)  {			
			source.develop(student);
		}
    }
}