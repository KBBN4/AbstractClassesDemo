using System;
namespace ConsoleUI
{
	abstract class Vehicle
	{
		public int Year { get; set; } = 2025;

		public string Make { get; set; } = "Default";

		public string Model { get; set; } = "Default";

//* Vehicle shall have an abstract method called DriveAbstract with no implementation

		public abstract void DriveAbstract();

		//* Vehicle shall have a virtual method called DriveVirtual with a base implementation

		public virtual void DriveVirtual ()
		{
		 Console.WriteLine(" Here is your Vehicle Information");
		}

    }
}

