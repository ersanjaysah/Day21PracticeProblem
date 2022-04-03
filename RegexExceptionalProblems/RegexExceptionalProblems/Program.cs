using System;
using RegexExceptionalProblems;

namespace RegexExceptionalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string PasswordRulesUpperCase;
            Console.Write("Enter your Password:\n");
            PasswordRulesUpperCase = Console.ReadLine();
            RegexProblem.checkPasswordRulesUpperCase(PasswordRulesUpperCase);

        }
    }
}
