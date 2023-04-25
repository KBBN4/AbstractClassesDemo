using System;
namespace ConsoleUI
{
	internal class Car : Vehicle
	{
		public Car()
		{
		}
        public bool HasTruck { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine(" This vehicle is Drivable");
        }
    }
}

