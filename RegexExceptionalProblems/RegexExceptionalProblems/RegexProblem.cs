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

        public static string Regex_Email = (@"^[a-z]{3}(\.[a-z]{3})[@]bl.(|co|in)$");


        public bool ValidateFirstName(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);

        }
        public static void checkFirstName(string Email)
        {
            try
            {
                if (Email == String.Empty || Email == " ")
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(Email, Regex_Email) == false)
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.INVALID_INPUT, "Invalid input please check your Email Address ");
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
