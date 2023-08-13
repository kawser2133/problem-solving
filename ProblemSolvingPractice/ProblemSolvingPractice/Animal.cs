using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Inheritance Example
namespace ProblemSolvingPractice
{
    public class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : Animal
    {

        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }

    }
}
