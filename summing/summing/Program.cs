using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summing
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the numbers to sum");
			int sum = 0;
			while(true)
			{
				sum += Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Current Sum: {0}", sum);
			}
		}
	}
}
