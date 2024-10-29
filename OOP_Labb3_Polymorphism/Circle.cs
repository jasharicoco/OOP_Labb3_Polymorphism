namespace OOP_Labb3_Polymorphism
{
    internal class Circle : Geometry
    {
        public override string ToString() => "Circle";
        public int id { get; }
        private double _radius;
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
