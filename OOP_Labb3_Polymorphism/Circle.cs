namespace OOP_Labb3_Polymorphism
{
    internal class Circle : Geometry
    {
        // Overriding ToString and calling it the shape of the class makes presentation easier.
        public override string ToString() => "Circle";
        public int id { get; }
        private double _radius;
        // Getters and setters are not neccessary to ensure positive value for radius, since the method "CreateCircle"
        // also ensures positive user input. But these getters and setters were made before i decided to make the application-program
        // so i will leave them here as practice.
        // Same goes for every other get;set; in the other classes.
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid value for radius in Circle. Setting to default (0).");
                    _radius = 0; // Set to a default value instead of throwing an exception
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public Circle()
        {
            Radius = 4;
        }

        public Circle(int id, double radius)
        {
            this.id = id;
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }

        public override double Perimeter()
        {
            return Radius * 2 * Math.PI;
        }

        public override string Present()
        {
            return $"Circle {id}";
        }
    }
}
