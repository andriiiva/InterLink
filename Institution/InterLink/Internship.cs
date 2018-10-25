using InternshipTest.Person;
using System.Collections.Generic;
using System;

namespace InternshipTest.Institution.InterLink
{
	public class Internship
    {
		public string name { get; private set; }
		List<Student> students = new List<Student>();

        public Internship(string name)
        {
			this.name = name;
        }

		public void AddStudent(Student student, University university)
        {
			if (student.GetKnowledge() >= university.GetAverageKnowledge())
			{
				students.Add(student);
			}
        }
        
		public string GetStudents()
        {
			string studentsList = "";
            foreach (Student s in students)
            {
				studentsList = studentsList + s.name + "\n";
            }
			return studentsList;
        }
    }
}
