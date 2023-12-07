namespace ProblemSolvingPractice.Examples
{
    public class OverloadingExample
    {
        // Method with two integer parameters
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method with three integer parameters
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method with two double parameters
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method with a string parameter
        public string Add(string a, string b)
        {
            return a + b;
        }
    }

}
