using InternshipTest.KnowledgeSource;
namespace InternshipTest.Person
{
	public class Student : IKnowledgeSource
	{
		public string Name { get; private set; }
		public float PerceptionLvl { get; private set; }
		public bool IsNotebook { get; private set; }
		Knowledge knowledge = new Knowledge();

		public Student(string name, Knowledge knowledge, float perceptionLvl, bool isNotebook)
		{
			Name = name;
			PerceptionLvl = perceptionLvl;
			IsNotebook = isNotebook;
			SetKnowledge(knowledge);
		}

		private void SetKnowledge(Knowledge knowledge)
		{
			this.knowledge = knowledge;
		}

        public void AddKnowledgeTheory(float theory)
		{
           knowledge.AddTheory(theory * PerceptionLvl);
		}
        public void AddKnowledgePractic(float practice)
		{
            knowledge.AddPract(practice * PerceptionLvl);
		}

		public float GetKnowledgePract(){
			return knowledge.practicelvl;
		}

		public float GetKnowledgeTheory(){
			return knowledge.theorylvl;
		}
		public void develop(Student student){
			student.AddKnowledgeTheory(0.001f);
			student.AddKnowledgePractic(0.003f);
		}
    }
}