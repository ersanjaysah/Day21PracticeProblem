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

        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);

        }
        public static void checkFirstName(string FirstName)
        {
            try
            {
                if (FirstName == String.Empty || FirstName == " ")
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(FirstName, Regex_FirstName) == false)
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.INVALID_INPUT, "Invalid input please check your char of name ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message+"True");
            }
            //finally
            //{
            //    Console.WriteLine("True");
            //}
            Console.WriteLine("code is executed");
        }
    }
}
