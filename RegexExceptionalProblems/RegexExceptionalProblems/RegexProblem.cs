using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExceptionalProblems
{
    public class RegexProblem
    {

        public static string Regex_PasswordRulesUpperCase = ("^[A-Z][a-z]{7}$");


        public bool ValidatePasswordRulesUpperCase(string PasswordRulesUpperCase)
        {
            return Regex.IsMatch(PasswordRulesUpperCase, Regex_PasswordRulesUpperCase);

        }
        public static void checkPasswordRulesUpperCase(string PasswordRulesUpperCase)
        {
            try
            {
                if (PasswordRulesUpperCase == String.Empty || PasswordRulesUpperCase == " ")
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(PasswordRulesUpperCase, Regex_PasswordRulesUpperCase) == false)
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.INVALID_INPUT, "Invalid Password please check your Password ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           Console.WriteLine("code is executed");
        }
    }
}
