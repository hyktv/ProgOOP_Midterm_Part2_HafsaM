using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOOP_Midterm_Part2_HafsaM
{
    public class ItemDatabase
    {
        static List<Shape> shapes = new List<Shape>();

        //constructor
        public static void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }
        
        //methods
        public static double CalculateTotalArea()
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }
            return totalArea;
        }

        public static double CalculateTotalPerimeter()
        {
            double totalPerimeter = 0;
            foreach (var shape in shapes)
            {
                totalPerimeter += shape.CalculatePerimeter();
            }
            return totalPerimeter;
        }
    }
}
