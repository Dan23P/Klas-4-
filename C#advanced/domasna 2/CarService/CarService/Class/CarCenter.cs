using CarService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Class
{
    internal class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void WashCar()
        {
            Console.WriteLine("The vehicle is being washed at the car center.");
        }

        public void PumpGas()
        {
            Console.WriteLine("Gas is being pumped into the vehicle at the car center.");
        }

        public void CheckVehicle()
        {
            Console.WriteLine("The Vehicle is being checked for problems at the car center.");
        }

        public void FixVehicle()
        {
            Console.WriteLine("The vehicle is being repaired at the car center.");
        }
    }
}
