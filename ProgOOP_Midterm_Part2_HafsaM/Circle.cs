using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_HafsaM
{
    public class Circle : Shape
    {
        //feilds
        public double radius;

        //constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        //methods
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
