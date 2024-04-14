using CarService.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Interface
{
    internal interface IRepairService
    {
        void CheckVehicle();
        void FixVehicle();
    }
}
