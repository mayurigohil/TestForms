using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProjectWP.Mayuri.Model;

namespace TestProjectWP.Mayuri.Pages
{
    class BillingForm
    {
        public IWebDriver driver;

        public BillingForm(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Defining all the elements of the page
        public IWebElement FirstName => driver.FindElement(By.Id("wpforms-24-field_0"));
        public IWebElement LastName => driver.FindElement(By.Id("wpforms-24-field_0-last"));
        public IWebElement Email => driver.FindElement(By.Id("wpforms-24-field_1"));
        public IWebElement Phone => driver.FindElement(By.Id("wpforms-24-field_2"));
        public IWebElement AddressLine1 => driver.FindElement(By.Id("wpforms-24-field_3"));
        public IWebElement AddressLine2 => driver.FindElement(By.Id("wpforms-24-field_3-address2"));
        public IWebElement City => driver.FindElement(By.Id("wpforms-24-field_3-city"));
        public SelectElement State => new SelectElement(driver.FindElement(By.Id("wpforms-24-field_3-state")));
        public IWebElement Zipcode => driver.FindElement(By.Id("wpforms-24-field_3-postal"));
        public IWebElement AvailableItems => driver.FindElement(By.Id("wpforms-24-field_4_2"));  
        public IWebElement Comment => driver.FindElement(By.Id("wpforms-24-field_6"));
        public IWebElement Submit => driver.FindElement(By.Id("wpforms-submit-24"));

        //Method for performing actions when data is passed through a Testcase
        public void FillSubmit(String Fname, String Lname, String Emailid, String PhoneNo, String AL1, String AL2, String CityC, String StateDrop, string Zip, String Comments)
        {
            FirstName.SendKeys(Fname);
            LastName.SendKeys(Lname);
            Email.SendKeys(Emailid);
            Phone.SendKeys(PhoneNo);
            AddressLine1.SendKeys(AL1);
            AddressLine2.SendKeys(AL2);
            City.SendKeys(CityC);
            State.SelectByValue(StateDrop);
            Zipcode.SendKeys(Zip);
            AvailableItems.Click();
            Comment.SendKeys(Comments);
            Submit.Click();
        }

        //Function to perform action when data is passed throgh excel sheet or and array of data
        public void FillSubmit(DataFile Data)
        {
            FirstName.SendKeys(Data.FirstName);
            LastName.SendKeys(Data.LastName);
            Email.SendKeys(Data.Email);
            Phone.SendKeys(Data.Phone);
            AddressLine1.SendKeys(Data.AL1);
            AddressLine2.SendKeys(Data.AL2);
            City.SendKeys(Data.City);
            State.SelectByValue(Data.State);
            Zipcode.SendKeys(Data.Zipcode);
            AvailableItems.Click();
            Comment.SendKeys(Data.Comments);
            Submit.Click();
        }
    }
}

       
 
