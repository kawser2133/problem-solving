using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice
{
    //1.1 Create a class named Person with properties FirstName, LastName, and Age.
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        private static int totalPersons = 0;

        //1.2 Define a parameterless constructor that sets default values for the properties.
        public Person()
        {

        }

        //5. Create a parameterized constructor for the Person class that takes values for FirstName, LastName, and Age.
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            totalPersons++;
        }

        //2.2 Set values for their properties using the constructor and property assignment.
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //4. Add a method GetFullName to the Person class that returns the full name.
        public virtual string GetFullName()
        {
            return $"{firstName} {lastName}";
        }

        //8. Add a static property TotalPersons to the Person class to keep track of the total number of instances created.
        public static int TotalPersons { get { return totalPersons; } set { totalPersons = value; } }
    }

    public static class MyTest
    {
        public static void Main()
        {
            //2.1 Instantiate two Person objects named person1 and person2.
            var person1 = new Person();
            var person2 = new Person();

            //6. Initialize a Person object using the parameterized constructor and display its details.
            var person3 = new Person("Aslam", "Mia", 21);
            var person4 = new Person("Hamid", "Khan", 27);

            Console.WriteLine(person3.GetFullName());

            //3. Display the properties of person1 and person2 using Console.WriteLine.
            Console.WriteLine(person3.FirstName);
            Console.WriteLine(person3.LastName);
            Console.WriteLine(person3.Age);

            Console.WriteLine(person4.FirstName);

            person3 = new Student(1);
            person3.FirstName = "A";
            person3.LastName = "B";

            var result = person3.GetFullName();
            Console.WriteLine(result);
            Console.WriteLine(Person.TotalPersons);
            var person5 = new Person("Hamid", "Khan", 27);
            Console.WriteLine(Person.TotalPersons);

        }
    }

    //9.1 Create a subclass named Student that inherits from Person.
    public class Student : Person
    {
        private int studentId;

        public Student(int studentId)
        {
            this.studentId = studentId;
        }

        //9.2 Add a property StudentId to the Student class.
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        //10. Override the GetFullName method in the Student class to include the StudentId.
        public override string GetFullName()
        {
            var fullName = base.GetFullName();
            return $"Full Name: {fullName}, Student ID: {studentId}";
        }
    }
}
