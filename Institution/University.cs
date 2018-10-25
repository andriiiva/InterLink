using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
	public class University
	{
		public string name { get; private set; }
		List<Student> students = new List<Student>();

		public University(string name)
		{
			this.name = name;
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
				sum = sum + s.GetKnowledge();
			}
			return sum/students.Count;
        }
    }
}
