using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticePolymorphism
{
    public class BaseGeometricType  // Base class for Geometric Type
    {

        public double Width { get; set; }  // properties for width and height
        public double Height { get; set; }

        public virtual double calculateArea() // using virtual method for shape of the area
        {
            return Width * Height;
        }

        public virtual void DisplayArea()
        {
            Console.WriteLine("Area of the geomethric shape");
        }

    }
    public class Square : BaseGeometricType
    {
        public override double calculateArea()
        {

            return Width * Width;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"area of square: {calculateArea()}");
        }

    }

    public class Rectangle : BaseGeometricType
    {
        public override double calculateArea()
        {
            return base.calculateArea();
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"Area of rectangle: {calculateArea()}");
        }
    }

    public class Triangle : BaseGeometricType
    {

        public override double calculateArea()
        {
            return (Width * Height) / 2;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"Area of triangle: {calculateArea()}");
        }
    }
}
