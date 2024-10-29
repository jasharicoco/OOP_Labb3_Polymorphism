namespace OOP_Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();

            List<Geometry> shapes = new List<Geometry>();
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(square);

            foreach (Geometry shape in shapes)
            {
                Console.WriteLine($"{shape} has an area of {shape.Area():F2}");
            }


        }
    }
}
