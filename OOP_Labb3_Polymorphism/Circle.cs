namespace OOP_Labb3_Polymorphism
{
    internal class Circle : Geometry
    {
        public override string ToString() => "Circle";
        public double Radius {  get; set; }

        public Circle()
        {
            Radius = 4;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }


    }
}
