using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("CHDTU");
            var student1 = new Student("Andrew Kostenko", new Knowledge(78));
            var student2 = new Student("Julia Veselkina", new Knowledge(92));
            var student3 = new Student("Maria Perechrest", new Knowledge(60));
            university.AddStudent(student1);
            university.AddStudent(student2);
            university.AddStudent(student3);

            Internship internship = new Internship("Interlink");
            internship.AddStudent(student1, university);
			internship.AddStudent(student2, university);
			internship.AddStudent(student3, university);
			Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
