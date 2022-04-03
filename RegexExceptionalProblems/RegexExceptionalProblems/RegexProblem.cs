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

        public static string Regex_MobileNumber = ("^91 [9876][0-9]{9}$");


        public bool ValidateMobileNumber(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, Regex_MobileNumber);

        }
        public static void checkMobileNumber(string MobileNumber)
        {
            try
            {
                if (MobileNumber == String.Empty || MobileNumber == " ")
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.NULL_FIELD, "Field is empty ");
                }
                else if (Regex.IsMatch(MobileNumber, Regex_MobileNumber) == false)
                {
                    throw new ExceptionalHandling(ExceptionalHandling.ExceptionType.INVALID_INPUT, "Invalid input please check your Mobile Number ");
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
