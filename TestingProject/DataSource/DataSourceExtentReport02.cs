using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.DataSource
{
    [TestClass]
    public class DataSourceExtentReport02
    {
        public static TestContext testContext;


        const string excelPath = "C:\\Users\\Admin\\source\\MyRepos\\TestingProject\\TestingProject\\DataSource\\CSVDataInEXCEL.xlsx";
        public static string path = "C:\\Users\\Admin\\source\\MyRepos\\TestingProject\\TestingProject\\PracticeExtentReport\\ReportOfExtent\\";
        public static ExtentReports extReports = new ExtentReports();
        public static ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(path);
        ExtentTest extentTest;

        [ClassInitialize]
        public static void ClassInit(TestContext contxt)
        {
            testContext = contxt; 
            extReports.AttachReporter(htmlReport);

        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            extReports.Flush();
            htmlReport.Stop();
        }

        [TestInitialize]
        public void TestInit()
        {
            extentTest = extReports.CreateTest($"{testContext.TestName} of {testContext.DataRow["State"]}");

        }

        [TestCleanup]
        public void TestClean()
        {

        }

            
        [TestMethod]
        [TestCategory("extent Report")]
        [TestCategory("Data source")]
        [DataSource("System.Data.OleDb", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelPath + ";Extended Properties=Excel 12.0",
                    "Login$", DataAccessMethod.Sequential)]
        public void State_details()
        {
           
            string number = testContext.DataRow[0].ToString();
            string state = testContext.DataRow[1].ToString();
            string capital = testContext.DataRow[2].ToString();

            string res = $"slno--> {number},state-->{state},capital-->{capital} ";

            extentTest.Info(res);
            Console.WriteLine(extentTest);

        }
    }
}
