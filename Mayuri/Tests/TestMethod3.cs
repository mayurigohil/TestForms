using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectWP.Mayuri.Model;
using TestProjectWP.Mayuri.Pages;

namespace TestProjectWP.Mayuri.Tests
{
    class TestMethod3 : SetUp
    {
        [Test]
        public void Datacollection()
            {
            DataFile Data = new DataFile("Test2", "Lastname", "Asdf@test.com", "1231231234", "Al1", "AL2", "City", "AL", "12345678", "comments passed");
            BillingForm FillData = new BillingForm(driver);
            FillData.FillSubmit(Data);
            }
        
    }
}
