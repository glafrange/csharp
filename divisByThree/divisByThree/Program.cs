using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisByThree
{
	class Program
	{
		static void Main(string[] args)
		{
			for (var i = 1; i <= 10; i++)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
