using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RegexUserRegistration;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        Program program = new Program();
        RegistrationPattern registrationPattern = new RegistrationPattern();
        [TestMethod]
        public void TestFirstName()
        {
            var result = registrationPattern.ValidateFirstName("Arati");
            Assert.AreEqual("validation successfull", result); 
        }

        [TestMethod]
        public void TestLastName()
        {
            var result = registrationPattern.ValidateLastName("Naik");
            Assert.AreEqual("validation successfull", result);
        }

        [TestMethod]
        public void TestEmail()
        {
            var result = registrationPattern.ValidateEmail("abc.xyz@bl.co.in");
            Assert.AreEqual("validation successfull", result);
        }

        [TestMethod]
        public void TestMobileNumber()
        {
            var result = registrationPattern.ValidateMobileNumber("91 9876543210");
            Assert.AreEqual("validation successfull", result);
        }

        [TestMethod]
        public void TestPassword()
        {
            var result = registrationPattern.ValidatePassword("Arati@12345");
            Assert.AreEqual("validation successfull", result);
        }
    }
}
