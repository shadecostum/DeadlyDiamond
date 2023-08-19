using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamond.Models
{
    internal class ElectricVehicle :Bike//,Car occur  Deadly diamond problem
    {
        public ElectricVehicle() {
            Console.WriteLine("Default Constructor of Electric Vehicle");
        }
    }
}
