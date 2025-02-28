using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    public abstract class Shape
    {
        public Shape(string shape_name)
        {
            Console.Write("Area of " + shape_name + " : ");
        }
        public abstract void CalculateArea();
    }

    public class Rectangle : Shape
    {
        private int length;
        private int breadth;
        public Rectangle(int length, int breadth) : base("Rectangle")
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void CalculateArea()
        {
            Console.WriteLine(length * breadth);
        }
    }

    public class Circle : Shape
    {
        private int radius;
        public Circle(int radius) : base("Circle")
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            Console.WriteLine(3.14 * radius * radius);
        }
    }
}
