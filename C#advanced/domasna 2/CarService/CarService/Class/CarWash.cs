using CarService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Class
{
    internal class CarWash : ICarWash

    {
        public void WashCar()
        {
            Console.WriteLine("The vehicle is being washed.");
        }
    }
}
