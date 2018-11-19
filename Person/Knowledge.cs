namespace InternshipTest
{
    public class Knowledge
    {
		public float practicelvl { get; private set; }
        public float theorylvl { get; private set; }

        public Knowledge () {

        }    
		public Knowledge(float practicelvl, float theorylvl)
        {
			this.practicelvl = practicelvl;
            this.theorylvl = theorylvl;
        }

        public void AddPract(float practicelvl){
            this.practicelvl = this.practicelvl + practicelvl;
        }

        public void AddTheory(float theorylvl){
            this.theorylvl = this.theorylvl + theorylvl;
        }
    }
}
