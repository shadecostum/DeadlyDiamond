using DeadlyDiamond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================");
            Vehicle vehicle = new Vehicle();
            Console.WriteLine("=========================================================");
            Bike bike = new Bike();
            Console.WriteLine("=========================================================");
            Car car = new Car();
            Console.WriteLine("=========================================================");
            ElectricVehicle electricVehicle = new ElectricVehicle();
            Console.WriteLine("=========================================================");
             ElectricBikeCar electricBikeCar = new ElectricBikeCar();
            Console.WriteLine("=========================================================");
            ElectricBikeCar electricBikeCar2 = new ElectricBikeCar("A");
            Console.WriteLine("=========================================================");


        }
    }
}
