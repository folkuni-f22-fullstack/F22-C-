using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using motsvarar import

namespace ConsoleApp
{
	// en klass motsvarar ett TypeScript-interface
	// det är en mall som kan användas för att skapa objekt
	public class Car : ICanDrive
	{
		public string Model { get; set; }
		// Skapa en egenskap med namnet "Model"

		public int WheelCount { get; set; }


		private decimal Price { get; set; }

		public void Drive()
		{
			Console.WriteLine("Wroooooom");
		}

		// Synlighetsnivåer: public, protected, private, internal
	}
}
