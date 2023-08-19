using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamond.Models
{
    internal class ElectricBikeCar : ElectricCar
    {
        public ElectricBikeCar() {
            Console.WriteLine("Elctric Bike and car created");
        }
        public ElectricBikeCar(string name)
        {
            Console.WriteLine("All parent class default Constructor called"+name);
        }
    }
}
