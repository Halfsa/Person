using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person("Janika",12,"meincraft");
			Person p2 = new Person();
			Student s = new Student("Gizi",25,"bool variable","Floptropica");
			Student s2 = new Student();
			Mentor mentor = new Mentor("Mateszopsz Péter",19,"male","senior");
			Mentor mentor1 = new Mentor();
			Console.WriteLine(p.Introduce());
			Console.WriteLine(p2.Introduce());
			s.skipDays(30);
			s2.skipDays(1);
            Console.WriteLine(s.Introduce());
			Console.WriteLine(s2.Introduce());
            Console.WriteLine(mentor.Introduce());
            Console.WriteLine(mentor1.Introduce());
            Console.ReadKey();

		}
	}
}
