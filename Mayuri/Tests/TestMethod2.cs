using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectWP.Mayuri.Pages;

namespace TestProjectWP.Mayuri.Tests
{
    class TestMethod2 :SetUp
    {
        //Passing data in Testcase
        [TestCase("Test2", "Lastname", "Asdf@test.com", "1231231234", "Al1", "AL2", "City", "AL", "123456", "comments passed")]
        [TestCase("test3", "Lastname", "Asdf@test.com", "1231231234", "Al1", "AL2", "City", "AL", "123456", "comments passed")]
        public void TestMethodTwo(String Fname, String Lname, String Emailid, String PhoneNo, String AL1, String AL2, String CityC, String StateDrop, string Zip, String Comments)
        {
            BillingForm obj2 = new BillingForm(driver);
            obj2.FillSubmit(Fname, Lname, Emailid, PhoneNo, AL1, AL2, CityC, StateDrop, Zip, Comments);
        }
    }
}
