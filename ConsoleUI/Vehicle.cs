using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public List<Vehicle> VehicleList { get; set; } = new List<Vehicle>();

        public abstract void DriveAbstract();
        public virtual void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"I am driving my vehicle, it is a {vehicle.Make} {vehicle.Model}");
        }
    }
}
