using System;

namespace Properties
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Person bob = new Person("Robert", "McAllister");
			Console.WriteLine(bob.Name);

			bob.NetWorth = 160020.23m;
			Console.WriteLine(string.Format("{0}'s net worth is: ${1}", bob.Name, bob.NetWorth));

			bob.Age = 55;
			Console.WriteLine("Bob is " + bob.Age + " years old.");
        }
    }
}
