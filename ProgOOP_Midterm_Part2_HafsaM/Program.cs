namespace ProgOOP_Midterm_Part2_HafsaM
{
    //Hafsa Mohamed
    //midterm part 2

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating shapes and adding them to the database
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Shape triangle = new Triangle(3, 4, 5);

            ItemDatabase.AddShape(circle);
            ItemDatabase.AddShape(rectangle);
            ItemDatabase.AddShape(triangle);

            // Calculating total area and perimeter
            double totalArea = ItemDatabase.CalculateTotalArea();
            double totalPerimeter = ItemDatabase.CalculateTotalPerimeter();

            //Display all info
            Console.WriteLine("Total Area of all shapes: " + totalArea);
            Console.WriteLine("Total Perimeter of all shapes: " + totalPerimeter);

        }
    }
}