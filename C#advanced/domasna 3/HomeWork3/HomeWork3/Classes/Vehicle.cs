using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Classes
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }
        public virtual void PrintVehicle ()
        {
            Console.WriteLine("The information about the vehicle is : ");
            Console.WriteLine($"The vehicles id is: {Id}");
            Console.WriteLine($"The vehicles type is> {Type}");
            Console.WriteLine($"The vehicles year of production is: {YearOfProduction}");
        }
    }
}
