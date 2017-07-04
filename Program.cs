using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class Program
	{
		static void Main()
		{
			do
			{
				Console.WriteLine("Welcome to the Factorial Calculator");
				Console.WriteLine("Enter an Integar thats greater than 0 and less than 10");
				int n = int.Parse(Console.ReadLine());

				for (int i = n; i > 1; i--)
				{
					n = n * (i - 1);

				}
				Console.WriteLine(n);
					
			}

			while (Continue() == true);

		}

		public static Boolean Continue()
		{
			Boolean run;
			Console.WriteLine("Continue: y/n?");
			string answer = Console.ReadLine();

			if ((answer == "Y") || (answer == "y"))
			{
				run = true;
			}
			else if ((answer == "N") || (answer == "n"))
			{
				run = false;
				Console.WriteLine("Later.");
			}
			else
			{
				Console.WriteLine("Yadda Yadda");
				run = Continue();
			}
			return run;
		}




	}
}
