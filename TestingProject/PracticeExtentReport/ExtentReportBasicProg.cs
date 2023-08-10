
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.PracticeExtentReport
{
    [TestClass]
    [TestCategory("extent Report")]
    public class ExtentReportBasicProg
    {
        public static string path = "C:\\Users\\Admin\\source\\MyRepos\\TestingProject\\TestingProject\\PracticeExtentReport\\ReportOfExtent\\";
        [TestMethod]
        public void execute()
        {
             ExtentReports extReports=new ExtentReports();
            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(path);
           // htmlReport.Start();
            extReports.AddSystemInfo("Organisation", "testYantra");
            extReports.AttachReporter(htmlReport);

            ExtentTest extentTest= extReports.CreateTest("Extent---Report--1");
            extentTest.Log(Status.Info, "This is info status");
            extentTest.Log(Status.Warning, "This is warning status");
            extentTest.Info("This is a info method");
            extentTest.Fail("test failed");
            extentTest.Log(Status.Fatal, "this is a status fatal");
            extentTest.Pass("test passed");
           

            ExtentTest extendTest2= extReports.CreateTest("extent--report--2");
            extendTest2.Info("This the 2nd report");
            extendTest2.Log(Status.Warning, "again warning");
            extendTest2.Pass("passing agin");

            extReports.Flush();
            htmlReport.Stop();
           // htmlReport.Flush();






        }
    }
}
