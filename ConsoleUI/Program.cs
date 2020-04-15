using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments in each section! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances, 1 Car, 1 Motorcycle, and then 2 Vehicles - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car myCar = new Car() {Year = 2014, Make = "Buick", Model = "Encore", HasTrunk = true };

            Motorcycle myMotorcycle = new Motorcycle() { Year = 1958, Make = "Honda", Model = "Super Cub", HasSideCart = true };

            Vehicle vehicle1 = new Car() { Year = 2009, Make = "Honda", Model = "Civic", HasTrunk = true};

            Vehicle vehicle2 = new Motorcycle() { Year = 2009, Make = "Kawasaki", Model = "Ninja", HasSideCart = false };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(myCar);
            vehicles.Add(myMotorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year}, {vehicle.Make}, {vehicle.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.ReadLine();
            Console.WriteLine();

            myCar.DriveAbstract();
            myCar.DriveVirtual(myCar);

            Console.WriteLine();

            myMotorcycle.DriveAbstract();
            myMotorcycle.DriveVirtual(myMotorcycle);

            #endregion            
            Console.ReadLine();
        }
    }
}
