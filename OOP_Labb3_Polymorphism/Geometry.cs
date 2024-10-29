namespace OOP_Labb3_Polymorphism
{
    // Abstract base class.
    // This class cannot be instantiated directly. Instead, 
    // it serves as a template for derived shape classes.
    internal abstract class Geometry
    {
        // Abstract methods to calculate the area/perimeter of the shape.
        // Derived classes must implement this method with 
        // their specific calculation logic.
        public abstract double Area();

        public abstract double Perimeter();

        public abstract string Present();
    }
}
