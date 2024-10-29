namespace OOP_Labb3_Polymorphism
{
    internal class Square : Geometry
    {
        public override string ToString() => "Square";
        public double Side { get; set; }

        public Square()
        {
            Side = 9;
        }

        public override double Area()
        {
            return Side * Side;
        }


    }
}
