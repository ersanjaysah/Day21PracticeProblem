using System;
using RegexExceptionalProblems;

namespace RegexExceptionalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string Email;
            Console.Write("Enter your Last Name : ");
            Email = Console.ReadLine();
            RegexProblem.checkFirstName(Email);
            
        }
    }
}
