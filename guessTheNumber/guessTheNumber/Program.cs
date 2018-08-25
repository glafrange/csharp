using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var random = new Random().Next(1, 10);
			bool winner = false;
			for (var tries = 0; tries < 4; tries++)
			{
				Console.WriteLine("guess the number between 1 - 10");
				if (Convert.ToInt32(Console.ReadLine()) == random)
				{
					winner = true;
					break;
				}
			}
			Console.WriteLine("{0}", winner ? "You win!" : "You lose! the correct number was : " + random);
		}
	}
}
