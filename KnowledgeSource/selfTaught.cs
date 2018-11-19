using InternshipTest.Person;
using System.Collections.Generic;
using System;

namespace InternshipTest.KnowledgeSource
{
	public class selfTaught : IKnowledgeSource
    {

		public void develop(Student student){
			student.AddKnowledgeTheory(0.005f);
			student.AddKnowledgePractic(0.0025f);
		}
    }
}
