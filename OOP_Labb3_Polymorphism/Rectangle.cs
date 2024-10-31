namespace OOP_Labb3_Polymorphism
{
    internal class Rectangle : Geometry
    {
        public override string ToString() => "Rectangle";
        public int id;
        private double _base;
        private double _height;
        public double Base
        {
            get { return _base; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid value for base in Rectangle. Setting to default (0).");
                    _base = 0; // Set to a default value instead of throwing an exception
                }
                else
                {
                    _base = value;
                }
            }
        }
        public double Height
        {
            get { return _base; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid value for height. Setting to default (0).");
                    _height = 0; // Set to a default value instead of throwing an exception
                }
                else
                {
                    _height = value;
                }
            }
        }

        public Rectangle()
        {
            Base = 5;
            Height = 3;
        }

        public Rectangle(int id, double rectangleBase, double rectangleHeight)
        {
            this.id = id;
            Base = rectangleBase;
            Height = rectangleHeight;
        }

        public override double Area()
        {
            return Base * Height;
        }

        public override double Perimeter()
        {
            return (Base * 2) + (Height * 2);
        }

        public override string Present()
        {
            return $"Rectangle {id}";
        }

    }
}
