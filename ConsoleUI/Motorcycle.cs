using System;
namespace ConsoleUI
{
	internal  class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}
        public bool HasTruck { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine(" This Motorcycle better be Driveable");
        }

        // * Only in the Motorcycle class will you override the virtual drive method

        public override void DriveVirtual()
        {
            Console.WriteLine(" Virtual Drive? Take a test drive and find out");
        }
    }
}

