using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Classes
{
    internal class Bike : Vehicle
    {
        public string Color { get; set; }
        public override void PrintVehicle()
        {
            Console.WriteLine("Information about the bike: ");
            Console.WriteLine($"The bikes year of production is: {YearOfProduction}");
            Console.WriteLine($"The color of the bike is {Color}");
        }
    }
}
