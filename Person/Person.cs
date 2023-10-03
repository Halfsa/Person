﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
	internal class Person
	{
		private string name;
		private int age;
		private string gender;

		public Person(string name, int age, string gender)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
		}
		public Person()
		{
			this.name = "Jane Doe";
			this.age = 30;
			this.gender = "Female";
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
		public string Gender { get => gender; set => gender = value; }

		public virtual void getGoal()
		{
            Console.WriteLine("My goal is: Live for the moment!");
        }
		public virtual string Introduce()
		{
			return $"Hi😎, I'm {name}, a {age} year old {gender}";
		}
	}
}
