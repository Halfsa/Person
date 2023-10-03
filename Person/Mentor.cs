using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
	internal class Mentor : Person
	{
		private string level;

		public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
		{
			this.level = level;
		}
		public Mentor()
		{
			base.Name = "Jane Doe";
			base.Age = 30;
			base.Gender = "Flop";
			this.level = "intermediate";
		}
		public override void getGoal()
		{
            Console.WriteLine("My goal is: Educate brilliant junior software developers");
        }
		public override string Introduce()
		{
			return base.Introduce()+$" {level} mentor";
		}


	}
}
	

