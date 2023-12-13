using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Examples
{

    // First interface
    public interface ILogger
    {
        void LogMessage(string message);
        string LogProvider { get; set; }
    }

    // Second interface
    public interface IEmailLogger
    {
        void SendEmail(string to, string subject, string body);
    }

    // First class implementing the first interface
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Console Log: {message}");
        }

        public string LogProvider { get; set; }
    }

    // Second class implementing both interfaces
    public class EmailConsoleLogger : ILogger, IEmailLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Console Log: {message}");
        }

        public string LogProvider { get; set; }

        public void SendEmail(string to, string subject, string body)
        {
            // In a real application, you would send an email here
            Console.WriteLine($"Sending Email to {to} with subject '{subject}' and body '{body}'");
        }
    }

}
