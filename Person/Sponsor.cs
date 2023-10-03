using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
	internal class Sponsor : Person
	{
		private string company;
		private int hiredStudents;

		public Sponsor(string name, int age, string gender,string company) : base(name,age,gender)
		{
			this.company = company;
			this.hiredStudents = 0;
		}
		public Sponsor()
		{
			base.Name = "Jane Doe";
			base.Age = 30;
			base.Gender = "Alpha male!";
			this.company = "Google";
			this.hiredStudents = 0;
		}
		public override void getGoal()
		{
			Console.WriteLine("My goal is: Hire brilliant junior software developers.");
		}
		public override string Introduce()
		{
			return $"{base.Introduce()} who represents {this.company} and hired {this.hiredStudents} so far.";
		}
		public void Hire()
		{
			hiredStudents++;
		}
	}
}
