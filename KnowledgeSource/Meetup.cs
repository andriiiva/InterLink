using InternshipTest.Person;
using System.Collections.Generic;
using System;

namespace InternshipTest.KnowledgeSource
{
	public class Meetup : IKnowledgeSource
    {
        public string Name { get; private set; }
		private List<Student> students = new List<Student>();

		public Meetup(string name){
			Name = name;
		}

		public void develop(Student student){
			student.AddKnowledgeTheory(0.005f);
			if(student.IsNotebook){
				student.AddKnowledgePractic(0.02f);
			}
		}
    }
}
