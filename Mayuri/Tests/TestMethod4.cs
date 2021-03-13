using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestProjectWP.Mayuri.Model;
using TestProjectWP.Mayuri.Pages;

namespace TestProjectWP.Mayuri.Tests
{
    class TestMethod4:SetUp
    {
        [TestCaseSource("TestDataCSV")]



        public void DatacollectionFromCSV(DataFile data)
        {
            BillingForm FillData = new BillingForm(driver);
            FillData.FillSubmit(data);
        }

        public static IEnumerable TestDataCSV()
        {
            string filePath = "Mayuri\\Data\\TestData.csv";  //C:\Users\Dell\Downloads\TestProjectWP\TestProjectWP\Mayuri\Data
            //reading csv file
            using (var csv = new CsvReader(new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + filePath)), true))
            {
                //Iterating csv file
                while (csv.ReadNextRecord())
                {
                    yield return new TestCaseData(new DataFile(csv[0], csv[1], csv[2], csv[3], csv[4], csv[5], csv[6], csv[7], csv[8], csv[9])).SetName(csv[10]);
                }
            }
        }
    }
}
