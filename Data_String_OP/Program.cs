using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransformation
{
	static class Program
	{

		public enum Gender
		{
			Male,
			Female
		}

		public enum GenderInitiate
		{
			Male = 1,
			Female = 2
		}


		internal class Person

		{



			public Gender? Gender { get; set; }

		}


		static void Main(string[] args)
		{

			//Convert 3 integers and create a DateTime for birthdate
			Console.WriteLine("Please insert your birthdate (day--month--year)");
			Console.WriteLine("Day:");
			int dayofBirth = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Month:");
			int monthofBirth = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Year:");
			int yearofBirth = Convert.ToInt32(Console.ReadLine());

			DateTime myBirthday = new DateTime(yearofBirth, monthofBirth, dayofBirth);
			Console.WriteLine("Your birthday is: " + myBirthday.ToString());

			//Compute the age of the person based on the birthdate
			// Save today's date.
			var today = DateTime.Today;
			// Calculate the age.
			int age = today.Year - yearofBirth;
			// Go back to the year the person was born in case of a leap year
			if (myBirthday > today.AddYears(-age)) age--;

			Console.WriteLine("You are " + age + " years old");

			//Enum gender/nullable//retired
			var p = new Person();
			Console.Write("State your gender:");

			string line = Console.ReadLine();

			if (Enum.TryParse<Gender>(line, out Gender g))

			{

				p.Gender = g;

			}

			if (p.Gender == null)

			{

				switch (line)

				{

					case "M":

						p.Gender = Gender.Male;

						break;

					case "F":

						p.Gender = Gender.Female;

						break;

				}

			}

			if (p.Gender != null)

			{

				Console.WriteLine("Valid gender: " + p.Gender);
				if (p.Gender == Gender.Female)
				{
					if (age < 63)
					{
						Console.WriteLine("You should retire at 63 years old! ");

					}
					else if (age >= 63)
					{
						Console.WriteLine("You retired at 63 years old!");
					}
				}
				else if (p.Gender == Gender.Male)
				{
					if (age < 65)
					{
						Console.WriteLine("You should retire at 65 years old! ");

					}
					else if (age >= 65)
					{
						Console.WriteLine("You retired at 65 years old!");
					}
				}

			}

			else

			{

				Console.WriteLine("Invalid gender");

			}

			Console.ReadLine();




		}
	}
}
