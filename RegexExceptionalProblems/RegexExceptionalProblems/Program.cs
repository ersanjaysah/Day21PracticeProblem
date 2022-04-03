using System;
using RegexExceptionalProblems;

namespace RegexExceptionalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the regex Program ");

            string PasswordRulesSpecialChar;
            Console.Write("Enter your Password:\n");
            PasswordRulesSpecialChar = Console.ReadLine();
            RegexProblem.checkPasswordRulesSpecialChar(PasswordRulesSpecialChar);

        }
    }
}
