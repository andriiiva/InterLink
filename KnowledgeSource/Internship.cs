using InternshipTest.Person;
using System.Collections.Generic;
using System;

namespace InternshipTest.KnowledgeSource
{
	public class Internship : IKnowledgeSource
    {
		public string name { get; private set; }
		List<Student> students = new List<Student>();

        public Internship(string name)
        {
			this.name = name;
        }

		public void AddStudent(Student student, University university)
        {
			if (student.GetKnowledgePract()+student.GetKnowledgeTheory()/2 >= university.GetAverageKnowledge())
			{
				students.Add(student);
			}
        }
        
		public string GetStudents()
        {
			string studentsList = "";
            foreach (Student s in students)
            {
				studentsList = studentsList + s.Name + "\n";
            }
			return studentsList;
        }

		public void develop(Student student){
			if(students.Contains(student)){
				student.AddKnowledgeTheory(0.04f);
				student.AddKnowledgePractic(0.085f);
			}
		}
    }
}
