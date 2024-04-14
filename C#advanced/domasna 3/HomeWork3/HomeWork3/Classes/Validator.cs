using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.Classes
{
    internal class Validator
    {
        public static bool Validation(Vehicle vehicle)
        {
            return vehicle.Id != 0 && !string.IsNullOrEmpty(vehicle.Type) && vehicle.YearOfProduction != 0;
        }
    }
}
