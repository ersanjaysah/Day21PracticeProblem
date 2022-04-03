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

        public static string Regex_PasswordRulesNumberic = ("^[A-Z][0-9][a-z]{6}$");


        public bool ValidatePasswordRulesNumberic(string PasswordRulesNumberic)
        {
            return Regex.IsMatch(PasswordRulesNumberic, Regex_PasswordRulesNumberic);

        }
        public static void checkPasswordRulesNumberic(string PasswordRulesNumberic)
        {
            try
            {
                if (PasswordRulesNumberic == String.Empty || PasswordRulesNumberic == " ")
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(PasswordRulesNumberic, Regex_PasswordRulesNumberic) == false)
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
