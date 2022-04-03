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

        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        public bool ValidateFirstName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);

        }
        public static void checkFirstName(string LastName)
        {
            try
            {
                if (LastName == String.Empty || LastName == " ")
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(LastName, Regex_LastName) == false)
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.INVALID_INPUT, "Invalid input please check your char of name ");
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
