using System;

// Base class
class Animal
{
    // Virtual method
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a generic sound.");
    }
}

// Derived class
class Dog : Animal
{
    // Override the MakeSound method from the base class
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks: Woof! Woof!");
    }
}

// Another derived class
class Cat : Animal
{
    // Override the MakeSound method from the base class
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows: Meow! Meow!");
    }
}
