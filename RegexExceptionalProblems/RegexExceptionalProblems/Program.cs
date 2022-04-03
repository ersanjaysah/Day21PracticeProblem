using System;
using RegexExceptionalProblems;

namespace RegexExceptionalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string FirstName;
            Console.Write("Enter your First Name : ");
            FirstName = Console.ReadLine();
            RegexProblem.checkFirstName(FirstName);
            
        }
    }
}
