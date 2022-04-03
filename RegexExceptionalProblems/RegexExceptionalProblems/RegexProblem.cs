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

        public static string Regex_PasswordRulesSpecialChar = (@"^[A-Z][0-9](|_|.|-|~)[a-z]{5}$");


        public bool ValidatePasswordRulesSpecialChar(string PasswordRulesSpecialChar)
        {
            return Regex.IsMatch(PasswordRulesSpecialChar, Regex_PasswordRulesSpecialChar);

        }
        public static void checkPasswordRulesSpecialChar(string PasswordRulesSpecialChar)
        {
            try
            {
                if (PasswordRulesSpecialChar == String.Empty || PasswordRulesSpecialChar == " ")
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(PasswordRulesSpecialChar, Regex_PasswordRulesSpecialChar) == false)
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
