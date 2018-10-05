using System;

namespace Properties
{
    public class Person
    {
		// Two variables that will make up a combined property
		private string firstName;
		private string lastName;

        // Private background field that will be accessed
        // through the 'NetWorth' property
		decimal netWorth;

        public Person(string first, string last)
		{
			firstName = first;
			lastName = last;
		}

        // Property created from two private fields
		public string Name => $"{firstName} {lastName}";

        // Public property using private variable for value
        public decimal NetWorth
		{
			get => netWorth;
			set => netWorth = value;
		}

        // Public property with default set and get of raw value
        public int Age
		{ get; set; }
    }
}
