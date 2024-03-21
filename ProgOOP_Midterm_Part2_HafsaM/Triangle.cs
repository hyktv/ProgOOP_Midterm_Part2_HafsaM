using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_HafsaM
{
    public class Triangle : Shape
    {
        //feilds
        public double side1;
        public double side2;
        public double side3;

        //constructor
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        //methods
        public override double CalculateArea()
        {
            // Heron's formula for area of a triangle
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
