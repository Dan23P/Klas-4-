using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Classes
{
    internal class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> CountriesProducedIn { get; set; } = new List<string>();
        public override void PrintVehicle ()
        {
            Console.WriteLine("Information about the car: ");
            Console.WriteLine($"The cars type is: {Type}");
            Console.WriteLine($"The car is produced in: {string.Join(",", CountriesProducedIn)}");
        }
    }
}
