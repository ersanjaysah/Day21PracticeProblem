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

        public static string Regex_PasswordRules = ("^[A-Za-z0-9]{8}$");


        public bool ValidatePasswordRules(string PasswordRules)
        {
            return Regex.IsMatch(PasswordRules, Regex_PasswordRules);

        }
        public static void checkPasswordRules(string PasswordRules)
        {
            try
            {
                if (PasswordRules == String.Empty || PasswordRules == " ")
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(PasswordRules, Regex_PasswordRules) == false)
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
