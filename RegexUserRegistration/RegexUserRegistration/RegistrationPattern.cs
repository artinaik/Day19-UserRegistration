using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    class RegistrationPattern
    {
        public static string regex_firstName = "^[A-Z]{1}[a-z]{2,}$";
        public static string regex_lastName = "^[A-Z]{1}[a-z]{2,}$";
        public static string regex_email = "^[a-z0-9]+(.[a-z0-9]+)?@[a-z]+[.][a-z]{2,3}(.[a-z]{2})?$";
        public void ValidateFirstName(string firstName)
        {
            if(Regex.IsMatch(firstName, regex_firstName).Equals(true))
            {
                Console.WriteLine("Validation successfull..");
            }
            else
            {
                Console.WriteLine("Hint : First Name should start with capital letter and should have minumim three characters");
            }
        }
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, regex_lastName).Equals(true))
            {
                Console.WriteLine("Validation successfull..");
            }
            else
            {
                Console.WriteLine("Hint : Last Name should start with capital letter and should have minumim three characters");
            }
        }
        public void ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, regex_email).Equals(true))
            {
                Console.WriteLine("Validation successfull..");
            }
            else
            {
                Console.WriteLine("Hint : e.g abc.xyz@bl.co.in \nEmail has 3 mandatory parts (abc, bl,co) and 2 optional parts(xyz,in) precise @ and.positions");
            }
        }
    }
}
