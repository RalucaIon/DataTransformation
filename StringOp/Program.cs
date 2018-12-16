using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataOp
{
	static class Program
	{
		static void Main(string[] args)
		{
			//1) String compare
			string a = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Enim facilisis gravida neque convallis a cras semper auctor. Mi tempus imperdiet nulla malesuada pellentesque elit. Iaculis urna id volutpat lacus laoreet non curabitur. Sapien eget mi proin sed libero enim sed faucibus. Enim tortor at auctor urna nunc. Semper feugiat nibh sed pulvinar proin gravida hendrerit. Risus nullam eget felis eget nunc lobortis. Vulputate ut pharetra sit amet aliquam id diam maecenas ultricies. Fermentum leo vel orci porta non. Odio facilisis mauris sit amet massa.";
			string b = "Adipiscing elit ut aliquam purus sit amet luctus venenatis. Sed blandit libero volutpat sed cras ornare arcu. Purus in mollis nunc sed. Morbi tristique senectus et netus et malesuada fames ac turpis. Natoque penatibus et magnis dis parturient. Adipiscing elit duis tristique sollicitudin nibh sit amet. Magna eget est lorem ipsum dolor sit amet consectetur adipiscing. Maecenas pharetra convallis posuere morbi leo urna. Feugiat in fermentum posuere urna nec. Amet mattis vulputate enim nulla aliquet. Nibh cras pulvinar mattis nunc sed. Condimentum mattis pellentesque id nibh tortor id aliquet. Lobortis mattis aliquam faucibus purus in massa tempor nec. Eleifend quam adipiscing vitae proin sagittis nisl rhoncus. Ut aliquam purus sit amet. Augue eget arcu dictum varius duis at consectetur. Sit amet facilisis magna etiam tempor orci eu lobortis elementum. Mattis aliquam faucibus purus in massa tempor. Est ante in nibh mauris cursus mattis molestie a. Cursus eget nunc scelerisque viverra mauris in.";

			int c = string.Compare(a, b);

			if (c == -1)
			{
				Console.WriteLine("String a is smaller than string b" + c);
			}
			else if (c == 1)
			{
				Console.WriteLine("String b is smaller than string a" + c);
			}


			c = string.CompareOrdinal(b, a);
			Console.WriteLine("Compare ordinal string b to string a. The result is: " + c);

			c = a.CompareTo(b);
			Console.WriteLine("String c = a.Compare to(b). The result is: " + c);

			c = b.CompareTo(a);
			Console.WriteLine("String c = b.Compare to(a). The result is: " + c);


			//2) String Format
			string x = "Rothschild’s slipper orchid, one of the rarest flowers in the world, is characterized by its red stripes and long side petals. It can only grow in the rainforests of Mount Kinabalu in northern Borneo, a large Asian island. Its growth range is even more limited by elevation, growing only between 1,640 and 3,930 feet above sea level.Not only is this flower rare, but it can take up to ";
			int y = 15;
			string z = "years to blossom. Because it is so difficult to find, this orchid species has a high value on the black market where it is sold for as much as $5,000 per stem. This high cost makes them a target for smugglers which further threatens its already vulnerable existence.";
			string result = string.Format("{0} {1:0} {2}",
			x,
			y,
			z);
			// Write the result.
			Console.WriteLine("\n" + result);

			//3) String Concat
			string s1 = "Lorem ipsum dolor sit amet, vel brute noster ut, qui in choro nostro delicata. Dolorum mediocritatem vel no, id usu movet ocurreret, dicam impedit has eu. Vis iisque erroribus appellantur eu, habeo phaedrum pericula eos eu, verear percipit qui et. Vix facer congue accusata ea, ei veritus dolores mel.";
			string s2 = "Qui laudem quidam te, ius vitae graece eloquentiam an. Impedit offendit volutpat ea nam, usu ea aliquip officiis mediocrem. Te scribentur dissentiet nam. Percipit consequat no vix, assum nominavi deterruisset duo no. Vix ex aliquid vocibus percipit, an has honestatis appellantur. Eum zril incorrupte ad, malorum expetendis eam id, sit homero vivendo convenire id.";

			// Combine the 3 strings.
			string s3 = s1 + s2 + "Wisi inani an vis, novum dolores quo eu. In dicam meliore petentium vis, saepe fastidii singulis sed ut. Et qui vitae dignissim necessitatibus, ne nam ceteros evertitur vituperatoribus. An velit persecuti scribentur his, eu porro facer deleniti pro. An tota dicit mel, ei odio falli pro. Mel ridens intellegat percipitur ea, altera concludaturque est ei.";

			// Write the result 
			Console.WriteLine("\n" + s3);

			//4) String compare uppercase+lowercase
			// compararea stringurilor
			string xLowerCase = "ion raluca-oana";
			string xUpperCase = "Ion Raluca-Oana";

			// string compare - case sensitive
			if (string.Compare(xLowerCase, xUpperCase) == 0)
			{
				Console.WriteLine("\n Case sensitive: The two strings are the same.");
			}
			else
			{
				Console.WriteLine("\n Case sensitive: The two strings are different.");
			}

			// string compare - case insensitive 
			if (string.Compare(xLowerCase, xUpperCase, true) == 0)
			{
				Console.WriteLine("\n Case insensitive: The two strings are the same.");
			}
			else
			{
				Console.WriteLine("\nCase insensitive: The two strings are different.");
			}

			//5) String replace
			const string input = "The key tool of the speech was PROPAGANDA!";
			Console.WriteLine("::BEFORE::");
			Console.WriteLine(input);

			// Replace word (and following space) with a new word.
			// ... We assign to the Replace method's result.
			string output = input.Replace("key tool", "key note");
			Console.WriteLine("::AFTER::");
			Console.WriteLine(output + "\n");

			//6) String TrimEnd
			// Our example string array.
			string[] items = new string[]
			{
				"Snowflakes on a pretty nose,",
				"Must be winter I suppose,",
				"Soft they kiss the altered trees,",
				"Bare of summers verdant leaves."
			};

			// Loop and call TrimEnd.
			foreach (string item in items)
			{
				string trimmed = item.TrimEnd('?', '.', ',');
				Console.WriteLine(item + "   " + trimmed);

			}


			//7) String normalize
			const string readInput = "grève";

			string val2 = readInput.Normalize();
			Console.WriteLine(val2);

			string val3 = readInput.Normalize(NormalizationForm.FormD);
			Console.WriteLine(val3);

			string val4 = readInput.Normalize(NormalizationForm.FormKC);
			Console.WriteLine(val4);

			string val5 = readInput.Normalize(NormalizationForm.FormKD);
			Console.WriteLine(val5);


			Console.ReadLine();

		}
	}
}
