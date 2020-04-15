using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("beep beep");
        }
        public override void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"I am driving my car, it is a {vehicle.Make} {vehicle.Model}");
        }
    }
}
