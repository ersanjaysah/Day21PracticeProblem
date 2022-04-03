using System;
using RegexExceptionalProblems;

namespace RegexExceptionalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string MobileNumber;
            Console.Write("Enter your Mobile Number :\n ");
            MobileNumber = Console.ReadLine();
            RegexProblem.checkMobileNumber(MobileNumber);
            
        }
    }
}
