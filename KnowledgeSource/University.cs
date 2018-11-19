using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.KnowledgeSource
{
	public class University : IKnowledgeSource
	{
		public string Name { get; private set; }
		private List<Student> students = new List<Student>();

		public University(string name)
		{
			Name = name;
		}
		
		public void AddStudent(Student student)
		{
			students.Add(student);
		}

		public float GetAverageKnowledge()
        {
			float sum = 0f;
            foreach (Student s in students)
			{
				sum = sum + s.GetKnowledgePract() + s.GetKnowledgeTheory();
			}
			return sum/students.Count/2;
        }

		public void develop(Student student){
			if(students.Contains(student)){
				student.AddKnowledgeTheory(0.05f);
				student.AddKnowledgePractic(0.0025f);
			}
		}
    }
}
