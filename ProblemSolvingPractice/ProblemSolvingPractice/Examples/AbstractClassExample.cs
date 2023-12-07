using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Examples
{
    using System;

    // Abstract class
    abstract class Shape
    {
        // Property
        public string Name { get; set; }

        // Constructor
        public Shape(string name)
        {
            Name = name;
        }

        // Abstract method (no implementation)
        public abstract double CalculateArea();

        // Concrete method
        public void DisplayInfo()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }

    // Concrete class inheriting from the abstract class
    class Circle : Shape
    {
        // Property
        public double Radius { get; set; }

        // Constructor
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        // Implementation of the abstract method
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

}
