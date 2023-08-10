
public class ProblemSolving
{
    public static void Main()
    {
        int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        foreach (var item in values)
        {
            if (PrimeNumbers(item))
            {
                Console.WriteLine(item);
            }
        }
    }


    //Question 1: Write a C# program that takes two integers as input and calculates their sum. Display the result to the console.
    public static void SumMethod(int firstValue, int secondValue)
    {
        var result = firstValue + secondValue;
        Console.WriteLine(result);
    }


    //Question 2: Write a C# program that takes an array of integers as input and finds the maximum and minimum values in the array. Display both the maximum and minimum values to the console.
    public static void MinMaxFind(int[] values)
    {
        var minValue = values.Min();
        var maxValue = values.Max();

        Console.WriteLine("Minimum Value: " + minValue);
        Console.WriteLine("Maximum Value: " + maxValue);
    }


    //Question 3: Write a C# program to reverse a given string. The program should take a string as input and display the reversed string to the console.
    public static void StringReverse(string value)
    {
        var reverseValue = value.Reverse();
        var result = new string(reverseValue.ToArray());

        Console.WriteLine(result);
    }


    //Question 4: Write a C# program to find all prime numbers from 1 to N (N is a positive integer) and display them to the console. Prime numbers are natural numbers greater than 1 that have no positive divisors other than 1 and themselves.
    public static bool PrimeNumbers(int value)
    {
        if (value <= 1)
            return false;

        if (value == 2 || value == 3)
            return true;

        if (value % 2 == 0 || value % 3 == 0)
            return false;

        for (int i = 5; i * i <= value; i += 6)
        {
            if (value % i == 0 || value % (i + 2) == 0)
                return false;
        }

        return true;
    }


}