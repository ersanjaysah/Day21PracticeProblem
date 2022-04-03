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

        public static string Regex_EmailValidation = ("^[A-Za-z0-9.+-]{1,}[a-zA-Z0-9]@[a-z0-9]{1,}.(co|org|com|in|us|net|au|com.com|com.au)$");


        public bool ValidateEmailValidation(string EmailValidation)
        {
            return Regex.IsMatch(EmailValidation, Regex_EmailValidation);

        }
        public static void checkEmailValidation(string EmailValidation)
        {
            try
            {
                if (EmailValidation == String.Empty || EmailValidation == " ")
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(EmailValidation, Regex_EmailValidation) == false)
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.INVALID_INPUT, "Invalid Email please check your Email ");
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
