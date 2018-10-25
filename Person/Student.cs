namespace InternshipTest.Person
{
	public class Student
	{
		public string name { get; private set; }
		Knowledge knowledge = new Knowledge();

		public Student(string name, Knowledge knowledge)
		{
			this.name = name;
			SetKnowledge(knowledge);
		}

		public void SetKnowledge(Knowledge knowledge)
		{
			this.knowledge = knowledge;
		}

		public float GetKnowledge(){
			return knowledge.level;
		}
    }
}