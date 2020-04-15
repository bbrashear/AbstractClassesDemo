using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("vroom vroom");
        }

        public override void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"I am driving my motorcycle, it is a {vehicle.Make} {vehicle.Model}");
        }
    }
}
