using System.Collections.Generic;
using InternshipTest.KnowledgeSource;
using InternshipTest.Schedule;
using InternshipTest.Person;
using System;

namespace InternshipTest.Education
{
	public class Plan
	{
        public string Name { get; private set; }
        List<Task> plan = new List<Task>();

        public Plan(string name){
            Name = name;
        }
        public void addTask(IKnowledgeSource source, Period period, ISchedule schednle){
            plan.Add(new Task(source, period, schednle));
        }
        public void addTask(IKnowledgeSource source, ISchedule schednle){
            plan.Add(new Task(source, schednle));
        }
        public void addTask(Period period, ISchedule schednle){
            plan.Add(new Task(period, schednle));
        }

        public void teachStudent(Student student, Period period){
            for (DateTime currDate = period.GetStartDate(); currDate <= period.GetEndDate(); currDate = currDate.AddDays(1)){
                foreach (Task task in plan)
                {
                    if (task.isActiveDay(currDate)){
                        task.apply(student);
                    }
               }
            }
        }
    }
}