using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
	internal class Student : Person
	{
		private string previousOrganisation;
		private int skippedDays;

		public Student(string name, int age, string gender,string previousOrganisation) : base(name,age,gender)
		{
			this.previousOrganisation = previousOrganisation;
			this.skippedDays = 0;
		}
		public Student()
		{
			base.Name = "Jane Doe";
			base.Age = 30;
			base.Gender = "E-male";
			previousOrganisation = "School of Life";
			skippedDays = 0;
		}

		public string PreviousOrganisation { get => previousOrganisation; set => previousOrganisation = value; }
		public int SkippedDays { get => skippedDays; set => skippedDays = value; }

		public override void getGoal()
		{
            Console.WriteLine("My goal is: Be a junior software developer");
        }
		public override string Introduce()
		{
			return $"{base.Introduce()} from {previousOrganisation} who skipped {skippedDays} days from course already.";
		}
		public int skipDays(int numberOfDays)
		{
			skippedDays += numberOfDays;
			return skippedDays;
		}
	}
}
