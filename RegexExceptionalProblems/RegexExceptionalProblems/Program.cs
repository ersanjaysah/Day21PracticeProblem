using System;
using RegexExceptionalProblems;

namespace RegexExceptionalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string PasswordRulesNumberic;
            Console.Write("Enter your Password:\n");
            PasswordRulesNumberic = Console.ReadLine();
            RegexProblem.checkPasswordRulesNumberic(PasswordRulesNumberic);

        }
    }
}
