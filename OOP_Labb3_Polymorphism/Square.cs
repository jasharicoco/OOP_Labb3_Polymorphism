namespace OOP_Labb3_Polymorphism
{
    internal class Square : Geometry
    {
        public override string ToString() => "Square";
        private double _side;
        public double Side
        {
            get { return _side; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid value for side in Square. Setting to default (0).");
                    _side = 0; // Set to a default value instead of throwing an exception
                }
                else
                {
                    _side = value;
                }
            }
        }

        public Square()
        {
            Side = 9;
        }

        public Square(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return (Side * 4);
        }

    }
}
