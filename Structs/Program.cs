using System;

namespace Structs
{
	//Struct Setup
	public struct Person {
		public string Name;
		public int Age;
		public Person(string name, int age) {
			Name = name;
			Age = age;
		}
	}

	class MainClass
	{
		static void Main()
		{
			//Creates new person from the struct object
			Person p1 = new Person ("Alex", 9);
			Console.WriteLine ("p1 Name = {0} Age = {1}", p1.Name, p1.Age);
		}
	}
}
