using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice
{
    public class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }
    }


    public abstract class Shape1
    {
        public abstract double CalculateArea();
    }

    public class Circle1 : Shape1
    {
        public double Radius { get; set; }

        public Circle1(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }


    class Vehicle
    {
        public string Type { get; set; }

        public Vehicle()
        {
            Type = "Generic Vehicle";
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            Type = "Car";
        }
    }
}
