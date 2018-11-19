using System;
using InternshipTest.Person;
using InternshipTest.KnowledgeSource;
using InternshipTest.Education;
using InternshipTest.Schedule;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            University universityA = new University("CHDTU");
            var student1 = new Student("Andrew Kostenko", new Knowledge(78));
            var student2 = new Student("Julia Veselkina", new Knowledge(92));
            var student3 = new Student("Maria Perechrest", new Knowledge(60));
            universityA.AddStudent(student1);
            universityA.AddStudent(student2);
            universityA.AddStudent(student3);

            Internship internLink = new Internship("Interlink");
            internLink.AddStudent(student1, universityA);
			internLink.AddStudent(student2, universityA);
			internLink.AddStudent(student3, universityA);
			Console.WriteLine("List of internship's students:");
            Console.WriteLine(internLink.GetStudents());
            */
            var student1 = new Student("Andrew Kostenko", new Knowledge(60,60), 0.5f, true);
            var student2 = new Student("Andrew NeKostenko", new Knowledge(60,60), 0.5f, true);
            var student3 = new Student("NeAndrew Kostenko", new Knowledge(60,60), 0.5f, false);
            var student4 = new Student("NeAndrew NeKostenko", new Knowledge(60,60), 0.5f, true);
            University universityA = new University("CHDTU");
            universityA.AddStudent(student1);
            universityA.AddStudent(student2);
            universityA.AddStudent(student3);
            universityA.AddStudent(student4);
            University universityB = new University("CHNU");
            universityB.AddStudent(student4);
            Internship internLink = new Internship("Interlink");
            internLink.AddStudent(student1, universityA);
            internLink.AddStudent(student2, universityA);
            internLink.AddStudent(student3, universityB);
            internLink.AddStudent(student4, universityB);
            Meetup meetup = new Meetup("Митап");
            selfTaught selfTaught = new selfTaught();

            ISchedule workingDays = new DoWSchedule(DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Tuesday, DayOfWeek.Friday);
            ISchedule weekends = new DoWSchedule(DayOfWeek.Saturday, DayOfWeek.Sunday);
            ISchedule everyDays = new JoinSchedule(workingDays, weekends);
            ISchedule excludeSummer = new MonthSchedule(1, 2, 3, 4, 5, 9, 10, 11, 12);
            ISchedule academicSchedule = new JoinSchedule(excludeSummer, workingDays);
            ISchedule daysInLastWInMonth = new LastWoMSchedule(DayOfWeek.Friday);


            Plan pacificPlan = new Plan("Пацифист");
            pacificPlan.addTask(universityA, new Period(new DateTime(2015, 9, 1), new DateTime(2020, 7, 20)), academicSchedule);
            pacificPlan.addTask(universityB, new Period(new DateTime(2020, 9, 1), new DateTime(2022, 7, 20)), academicSchedule);

            Plan selfTaughtPlan = new Plan("Самоучка");
            selfTaughtPlan.addTask(internLink, new Period(new DateTime(2018, 9, 1), new DateTime(2020, 7, 20)), workingDays);
            selfTaughtPlan.addTask(meetup, daysInLastWInMonth);
            selfTaughtPlan.addTask(selfTaught, everyDays);

            Plan teachMEPlan = new Plan("Терпила");
            teachMEPlan.addTask(universityA, new Period(new DateTime(2018, 9, 1), new DateTime(2020, 7, 20)), academicSchedule);
            teachMEPlan.addTask(meetup, new Period(new DateTime(2018, 9, 1), new DateTime(2020, 7, 20)), daysInLastWInMonth);
            teachMEPlan.addTask(new Period(new DateTime(2018, 9, 1), new DateTime(2020, 7, 20)), everyDays);

            Plan enlightenedPlan = new Plan("Сознательный");
	        enlightenedPlan.addTask(universityA, new Period(new DateTime(2015, 9, 1), new DateTime(2020, 7, 20)), academicSchedule);
            enlightenedPlan.addTask(meetup, daysInLastWInMonth);
            enlightenedPlan.addTask(internLink, new Period(new DateTime(2018, 9, 1), new DateTime(2020, 7, 20)), workingDays);
            enlightenedPlan.addTask(selfTaught, everyDays);
            enlightenedPlan.addTask(student2, weekends);
            
            pacificPlan.teachStudent(student1, new Period(new DateTime(2015, 9, 1), new DateTime(2022, 7, 20)));
            selfTaughtPlan.teachStudent(student2, new Period(new DateTime(2015, 9, 1), new DateTime(2022, 7, 20)));
            teachMEPlan.teachStudent(student3, new Period(new DateTime(2015, 9, 1), new DateTime(2022, 7, 20)));
            enlightenedPlan.teachStudent(student4, new Period(new DateTime(2015, 9, 1), new DateTime(2022, 7, 20)));

            Console.WriteLine(student1.GetKnowledgePract() + " " + student1.GetKnowledgeTheory());
            Console.WriteLine(student2.GetKnowledgePract() + " " + student2.GetKnowledgeTheory());
            Console.WriteLine(student3.GetKnowledgePract() + " " + student3.GetKnowledgeTheory());
            Console.WriteLine(student4.GetKnowledgePract() + " " + student4.GetKnowledgeTheory());
        }
    }
}
