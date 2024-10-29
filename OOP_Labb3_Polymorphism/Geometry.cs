namespace OOP_Labb3_Polymorphism
{
    internal abstract class Geometry
    {
        // We are working with abstract here because we will not be creating any instances of "Geometry"
        // other than the ones coming from the sub-classes. Abstract methods force us to write specific
        // shape-related code for their respectice Area and Perimeter calculations.
        public abstract double Area();
        public abstract double Perimeter();
    }
}
