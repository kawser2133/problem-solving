using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice
{
    public static class BasicTests
    {
        //Declare a constant named taxRate and initialize it with a value.
        public const int taxRate = 10;

        //What is a readonly variable? Declare a readonly variable named city.
        private static readonly string city;

        public static void VariablesAndDataTypes()
        {
            //Declare an integer variable named age.
            int age;

            //Initialize a string variable named name with your own name.
            string name = "Hamid";

            //Declare a double variable named salary.
            double salary;

            //What is implicit conversion? Provide an example.
            int intValue = 10;
            double doubleValue = intValue;

            //What is explicit conversion? Show an example of explicit conversion.
            double doubleValue2 = 10.25;
            int intValue2 = (int)doubleValue2;

            //Perform addition, subtraction, multiplication, and division on two integer variables.
            int valueA = 68;
            int valueB = 24;

            var addition = valueA + valueB;
            var subtraction = valueA - valueB;
            var multiplication = valueA * valueB;
            var division = valueA / valueB;

            //Perform division and ensure the result is a decimal.
            double divisionResult = (double)valueA / valueB;

            //How do you concatenate strings in C#?
            string concatenateValue = "Hello " + "World!";

            //Create a message that combines a string and an integer variable.
            string employeeName = "Hamid";
            int employeeAge = 24;

            Console.WriteLine($"Employee Name: {employeeName}, Age: {employeeAge}");

        }


    }
}