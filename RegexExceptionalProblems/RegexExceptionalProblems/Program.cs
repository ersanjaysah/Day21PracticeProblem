using System;
using RegexExceptionalProblems;

namespace RegexExceptionalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string PasswordRules;
            Console.Write("Enter your Password :\n ");
            PasswordRules = Console.ReadLine();
            RegexProblem.checkPasswordRules(PasswordRules);

        }
    }
}
