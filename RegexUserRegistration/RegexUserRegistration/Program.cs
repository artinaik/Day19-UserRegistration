﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReflectionOnUserRegistration.ReflectionTest();
            RegistrationPattern.TakeUserInputs();
            Console.ReadKey();
        }
    }
}
