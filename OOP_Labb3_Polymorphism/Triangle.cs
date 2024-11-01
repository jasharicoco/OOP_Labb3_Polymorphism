﻿namespace OOP_Labb3_Polymorphism
{
    internal class Triangle : Geometry
    {
        public override string ToString() => "Triangle";
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
                    Console.WriteLine("Invalid value for base in Triangle. Setting to default (0).");
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
            get { return _height; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid value for height in Triangle. Setting to default (0).");
                    _height = 0; // Set to a default value instead of throwing an exception
                }
                else
                {
                    _height = value;
                }
            }
        }

        public Triangle()
        {
            Base = 4;
            Height = 10;
        }

        public Triangle(int id, double triangleBase, double triangleHeight)
        {
            this.id = id;
            Base = triangleBase;
            Height = triangleHeight;
        }

        public override double Area()
        {
            return (Base * Height) / 2;
        }

        // Only works for right-angled triangles
        public override double Perimeter()
        {
            double hypotenuse = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Height, 2)); // Pythagorean theorem
            return Base + Height + hypotenuse;
        }

        public override string Present()
        {
            return $"Triangle {id}";
        }

    }
}
