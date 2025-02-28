using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice_
{
    interface IVehicle
    {
        void Drive();
    }

    class Cars : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car");
        }
    }
    class Bikes : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a Bike");
        }
    }
    class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            if (type.Equals("Car", StringComparison.OrdinalIgnoreCase))
                return new Cars();
            else if (type.Equals("Bike", StringComparison.OrdinalIgnoreCase))
                return new Bikes();
            else
                throw new ArgumentException("Invalid vehicle type");
        }
    }

}