using CarService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Class
{
    internal class GasPump : IGasPump
    {
        public void PumpGas()
        {
            Console.WriteLine("Gas is being pumped into the vehicle.");
        }
    }
}
