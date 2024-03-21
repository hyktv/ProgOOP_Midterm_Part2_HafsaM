using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_HafsaM
{
    public class Rectangle : Shape
    {
        //feilds
        public double length;
        public double width;

        //constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        //methods
        public override double CalculateArea()
        {
            return length * width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
}
