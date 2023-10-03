using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
	internal class Cohort
	{
		private string name;
		private List<Student> students;
		private List<Mentor> mentors;
		public Cohort(string name) 
		{
			this.name = name;
			this.students = new List<Student>();
			this.mentors = new List<Mentor>();
		}
		public void addStudent(Student stud)
		{
			students.Add(stud);
		}
		public void addMentor(Mentor ment)
		{
			mentors.Add(ment);
		}
		public void info()
		{
            Console.WriteLine($"The {this.name} cohort has {students.Count} students and {mentors.Count} mentors");
        }
	}
}
