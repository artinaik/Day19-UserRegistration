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
        public static string regex_mobileNumber = "^[1-9][0-9]{1,2}[ ][0-9]{10}$";
        public static string regex_password = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";

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
        public void ValidateMobileNumber(string mobile)
        {
            if (Regex.IsMatch(mobile, regex_mobileNumber).Equals(true))
            {
                Console.WriteLine("Validation successfull..");
            }
            else
            {
                Console.WriteLine("Hint : Country code followed by space and 10 digit mobile number");
            }
        }
        public void ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, regex_password).Equals(true))
            {
                Console.WriteLine("Validation successfull..");
            }
            else
            {
                Console.WriteLine("Rule1 : Minimum 8 characters\nRule2 : Sould have atleast 1 capital letter \nRule3 : Should have atleast 1 digit");
            }
        }
    }
}
