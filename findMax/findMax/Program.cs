using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findMax
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a series of numbers separated by a comma");
			string[] list = Console.ReadLine().Split(',');
			int max = 0;
			for(var i = 0; i < list.Length; i++)
			{
				var currentNum = Convert.ToInt32(list[i]);
				if (currentNum > max)
				{
					max = currentNum;
				}
			}
			Console.WriteLine("The max is: {0}", max);
		}
	}
}
