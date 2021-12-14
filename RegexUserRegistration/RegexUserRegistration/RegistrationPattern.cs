using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    public class RegistrationPattern
    {
        string msg = "";
        public  string regex_firstName = "^[A-Z]{1}[a-z]{2,}$";
        public  string regex_lastName = "^[A-Z]{1}[a-z]{2,}$";
        public  string regex_email = "^[a-z0-9]+(.[a-z0-9]+)?@[a-z]+[.][a-z]{2,3}(.[a-z]{2})?$";
        public  string regex_mobileNumber = "^[1-9][0-9]{1,2}[ ][0-9]{10}$";
        public  string regex_password = "^(?=.*[A-Z])(?=.*[0-9])(?=.+[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$";
        public string ValidateFirstName(string firstName)
        {
            if(Regex.IsMatch(firstName, regex_firstName).Equals(true))
            {
                msg="validation successfull";
            }
            else
            {
                msg="Invalid FirstName";
            }
            return msg;
        }
        public string ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, regex_lastName).Equals(true))
            {
                msg = "validation successfull";
            }
            else
            {
                msg = "Invalid LastName";
            }
            return msg;
        }
        public string ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, regex_email).Equals(true))
            { 
                msg = "validation successfull";
            }
            else
            {
                msg = "Invalid Email";
            }
                return msg;
        }
        public string ValidateMobileNumber(string mobile)
        {
            if (Regex.IsMatch(mobile, regex_mobileNumber).Equals(true))
            {
                msg = "validation successfull";
            }
            else
            {
                msg = "Invalid Mobile Number";
            }
            return msg;
        }
        public string ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, regex_password).Equals(true))
            {
                msg = "validation successfull";
            }
            else
            {
                msg = "Invalid Password";
            }
            return msg;
        }
    }
}
