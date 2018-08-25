using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			int factorial = 1;
			Console.WriteLine("Enter a Number");
			int input = Convert.ToInt32(Console.ReadLine());
			for(var i = input; i > 0; i--)
			{
				factorial *= i;
			}
			Console.WriteLine("{0}! = {1}", input, factorial);
		}
	}
}
