using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;

namespace TestingProject.PracticeExtentReport
{
    [TestClass]
    [TestCategory("extent Report")]
    public class ExtentReportProg01
    {

        public  static ExtentReports extentReports;
        public static ExtentHtmlReporter htmlExtent;
        public  ExtentTest extest;
        public static string path= "C:\\Users\\Admin\\source\\MyRepos\\TestingProject\\TestingProject\\PracticeExtentReport\\ReportOfExtent\\";
    /*   [AssemblyInitialize]
        public static void ExtReportInitialize(TestContext testContext)
        {
           
             extentReports = new ExtentReports();
             htmlExtent = new ExtentHtmlReporter(path);
             htmlExtent.Start();
            //extentReports.AddSystemInfo("admin", "thejas");
             extentReports.AttachReporter(htmlExtent);
        }
        [AssemblyCleanup]
        [TestCategory("extent_Report_methods")]
        public static void clean()
        {
            extentReports.Flush();
            htmlExtent.Stop();

        }*/
        [TestMethod]
        [TestCategory("extent_Report_methods")]
        public void Prog01_test01()
        {
            extest=extentReports.CreateTest("Sushma Report");
            extest.Log(Status.Info,"Sushma is executing");
            extest.Log(Status.Warning,"Sushma is going to fail");
            extest.Fail("sushma is failed");
            extest.Pass("Sushma is pass");
        }

        [TestMethod]
        [TestCategory("extent_Report_methods")]
        public void Prog01_test02()
        {
            extest = extentReports.CreateTest("thejas Report");
            extest.Log(Status.Info, "thejas is executing");
            extest.Log(Status.Warning, "thejas is going to fail");
            extest.Fail("thejas is failed");
            extest.Pass("thejas is pass");
        }

        [TestMethod]
        [TestCategory("extent_Report_methods")]
        public void Prog01_test03()
        {
            extest = extentReports.CreateTest("datta Report");
            extest.Log(Status.Info, "datta is executing");
            extest.Log(Status.Warning, "datta is going to fail");
            extest.Fail("datta is failed");
            extest.Pass("datta is pass");
        }


        [TestMethod]
        [TestCategory("extent_Report_methods")]
        public void Prog01_test04()
        {
            extest = extentReports.CreateTest("veena Report");
            extest.Log(Status.Info, "veena is executing");
            extest.Log(Status.Warning, "veena is going to fail");
            extest.Fail("veena is failed");
            extest.Pass("veena is pass");
        }

    }
}
