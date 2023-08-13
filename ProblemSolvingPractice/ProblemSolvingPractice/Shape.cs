using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    public class Circle : Shape
    {
        private readonly string? Name;
        public Circle(string? name)
        {
            Name = name;
        }

        public required string MyProperty { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle" + Name + "-" + MyProperty);
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}
