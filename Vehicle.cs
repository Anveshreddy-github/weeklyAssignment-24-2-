using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice_
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is Starting...");
        }
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is Starting...");
        }
    }

    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is Starting...");
        }
    }
}
