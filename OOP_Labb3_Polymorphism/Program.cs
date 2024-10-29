namespace OOP_Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring new specific shape-typed object in the Geometry Class.
            // This enables us to save them in a shared list, which makes presentation and other functions more accessible.
            Geometry circle1 = new Circle();
            Geometry circle2 = new Circle(7);
            Geometry rectangle1 = new Rectangle();
            Geometry rectangle2 = new Rectangle(6, 8);
            Geometry square1 = new Square();
            Geometry square2 = new Square(7);
            Geometry triangle1 = new Triangle();
            Geometry triangle2 = new Triangle(12, 9);

            List<Geometry> shapes = new List<Geometry>();
            shapes.Add(circle1);
            shapes.Add(circle2);
            shapes.Add(rectangle1);
            shapes.Add(rectangle2);
            shapes.Add(square1);
            shapes.Add(square2);
            shapes.Add(triangle1);
            shapes.Add(triangle2);




            //---Sort and Display Areas---//
            
            List<Geometry> sortedByArea = shapes.OrderBy(shape => shape.Area()).ToList();
            Console.WriteLine("Shapes sorted by area:");
            foreach (Geometry shape in sortedByArea)
            {
                // Running one single method on all objects, because they have "Geometry Class" in common.
                Console.WriteLine($"A {shape} has an area of {shape.Area():F2}");
            }

            Console.WriteLine();
            //---Sort and Display Perimeter---//

            List<Geometry> sortedByPerimeter = shapes.OrderBy(shape => shape.Perimeter()).ToList();
            Console.WriteLine("Shapes sorted by perimeter:");
            foreach (Geometry shape in sortedByPerimeter)
            {
                // Running one single method on all objects, because they have "Geometry Class" in common.
                Console.WriteLine($"A {shape} has a perimeter of {shape.Perimeter():F2}");
            }


        }
    }
}
