
using ProblemSolvingPractice;
using System.Diagnostics;

public class Practices
{
    public static async Task Main()
    {
        Console.WriteLine("Main thread started.");

        Thread fetchThread1 = new Thread(() => FetchWeather("New York"));
        Thread fetchThread2 = new Thread(() => FetchWeather("London"));

        fetchThread1.Start();
        fetchThread2.Start();

        Stopwatch sw = Stopwatch.StartNew();
        fetchThread1.Join();
        Console.WriteLine($"S1-  {sw.Elapsed}");
        sw.Stop();

        Stopwatch sw1 = Stopwatch.StartNew();
        fetchThread2.Join();
        Console.WriteLine($"S2-  {sw1.Elapsed}");
        sw1.Stop();

        Console.WriteLine("Main thread finished.");


        Console.WriteLine("Main method started.");

        Task fetchTask1 = FetchWeatherAsync("New York");
        Task fetchTask2 = FetchWeatherAsync("London");

        Stopwatch sw3 = Stopwatch.StartNew();
        //await Task.WhenAll(fetchTask1, fetchTask2);
        await fetchTask1;
        Console.WriteLine($"S3-  {sw3.Elapsed}");
        sw3.Stop();
        Stopwatch sw4 = Stopwatch.StartNew();
        await fetchTask2;
        Console.WriteLine($"S4-  {sw4.Elapsed}");
        sw4.Stop();

        Console.WriteLine("Main method finished.");
    }

    public static async Task FetchWeatherAsync(string city)
    {
        Console.WriteLine($"Fetching weather for {city}...");

        await Task.Delay(TimeSpan.FromSeconds(2));
        //using var httpClient = new HttpClient();
        //await httpClient.GetStringAsync($"https://api.domainsdb.info/v1/domains/search?domain={city}&zone=com");
        Console.WriteLine($"Fetched weather for {city}...");
    }

    static void FetchWeather(string city)
    {
        Console.WriteLine($"Fetching weather for {city}...");
        // Simulate fetching weather by waiting
        Thread.Sleep(TimeSpan.FromSeconds(2));
        Console.WriteLine($"Fetched weather for {city}...");
    }

    public static class CustomCode
    {

        public static int[] TwoSum(int[] nums, int target)
        {
            int sumValue = 0;
            int[] returnValue = new int[] { };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);

            }
            // foreach(int value in nums)
            // {
            //     if(sumValue==target)
            //     {

            //     }

            // }
            return returnValue;
        }

        public static int find_total(int[] my_numbers)
        {
            int running_total = 0;

            foreach (var value in my_numbers)
            {
                if (value % 2 == 1 && value != 8)
                    running_total += 3;
                if (value % 2 == 0 && value != 8)
                    running_total += 1;
                if (value == 8)
                    running_total += 5;
            }

            return running_total;
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