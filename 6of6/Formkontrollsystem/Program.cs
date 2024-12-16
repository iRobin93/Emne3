/*Strategi
 * 
 * 
 * 
 * 
 */

namespace Formkontrollsystem
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(5, "Per", "Rød"));
            shapes.Add(new Circle(6, "Pål", "Grønn"));
            shapes.Add(new Rectangle(5, 5, "Espen", "Sølv"));
            shapes.Add(new Rectangle(10, 5, "Robin", "Blå"));
            shapes.Add(new Triangle(10, 5, "Ole Morten", "Gul"));
            shapes.Add(new Triangle(10, 10, "Mona", "Gul"));


            var shapeQuery = from shape in shapes
                             orderby shape.CalculateArea()
                             select shape;

            PrintShapes(shapeQuery);

            Console.WriteLine("Total area er: " + TotalArea(shapeQuery));
            ColorFilter(shapes, "Gul");
        }

        private static void PrintShapes(IEnumerable<Shape> shapeQuery)
        {
            foreach (Shape shape in shapeQuery)
            {
                Console.WriteLine("Navnet er: " + shape.GetName() + " fargen er: " + shape.GetColor() + " Arealet er: " + shape.CalculateArea());
            }
        }

        static double TotalArea(IEnumerable<Shape> shapeQuery)
        {
            double total = 0;
            foreach (Shape shape in shapeQuery) 
            {
                total += shape.CalculateArea();
            }
            return total;
        }

        static void ColorFilter(List<Shape> shapes, string filterColor)
        {
            var shapeQuery = from shape in shapes
                             where shape.GetColor() == filterColor
                             select shape;

            PrintShapes(shapeQuery);
        }
        


    }
}