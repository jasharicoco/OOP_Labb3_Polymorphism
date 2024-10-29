namespace OOP_Labb3_Polymorphism
{
    internal class Rectangle : Geometry
    {
        public override string ToString() => "Rectangle";
        public double Base { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Base = 5;
            Height = 3;            
        }

        public override double Area()
        {
            return Base * Height;
        }


    }
}
