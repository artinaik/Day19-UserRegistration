using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User registration using Regex");
            RegistrationPattern registrationPattern = new RegistrationPattern();
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            registrationPattern.ValidateFirstName(firstName);
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            registrationPattern.ValidateFirstName(lastName);
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            registrationPattern.ValidateEmail(email);
            Console.WriteLine("Enter Mobile Number");
            string mobile = Console.ReadLine();
            registrationPattern.ValidateMobileNumber(mobile);
            Console.WriteLine("Create Password");
            string password = Console.ReadLine();
            registrationPattern.ValidatePassword(password);
            Console.ReadKey();
        }
    }
}
