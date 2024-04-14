using CarService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Class
{
    internal class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("The vehicle is being checked for problems.");
        }

        public void FixVehicle()
        {
            Console.WriteLine("The vehicle is being repaired.");
        }
    }
}
