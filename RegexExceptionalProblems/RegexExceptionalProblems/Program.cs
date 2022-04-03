using System;
using RegexExceptionalProblems;

namespace RegexExceptionalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string LastName;
            Console.Write("Enter your Last Name : ");
            LastName = Console.ReadLine();
            RegexProblem.checkFirstName(LastName);
            
        }
    }
}
