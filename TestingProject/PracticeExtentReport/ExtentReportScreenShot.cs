using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestingProject.GenericUtility;

namespace TestingProject.PracticeExtentReport
{
    /// <summary>
    /// based on the boolean value provided in the DatatestMethod, browser will open and takes the screenshot of that.
    /// and this screenshot will be saved in the extent report.
    /// </summary>
    [TestClass]
    [TestCategory("extent Report")]
    public class ExtentReportScreenShot
    {
        public static IWebDriver driver;
        public static TestContext TextContxt;

        public static ExtentReports extentReports;
        public static ExtentHtmlReporter htmlExtent;
        public ExtentTest extest;
        public static string path = "C:\\Users\\Admin\\source\\MyRepos\\TestingProject\\TestingProject\\PracticeExtentReport\\ReportOfExtent\\";

        public static string screenshotPath;


   /*    [AssemblyInitialize]
        public static async Task ExtReportInitialize(TestContext testContext)
        {
            WebActionUtility wa = new WebActionUtility();
            wa.Implicit_Wait();
            TextContxt = testContext;
            extentReports = new ExtentReports();
            htmlExtent = new ExtentHtmlReporter(path);
           // htmlExtent.Start();
            //extentReports.AddSystemInfo("admin", "thejas");
            extentReports.AttachReporter(htmlExtent);
          
        }
        [AssemblyCleanup]
        public static void clean()
        {
      
        }*/
        [TestInitialize]
        public void test_Initialize()
        {

        }
        [TestCleanup]
        public void test_CleanUp()
        {
            extest.AddScreenCaptureFromPath(screenshotPath);
            extentReports.Flush();
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("Flipkart", "https://www.flipkart.com/", false)]
        [DataRow("Amazon", "https://www.amazon.in/", false)]
        [TestCategory("extent_Report_methods")]

        public void Exexute_Multiple_Browser_Test(string siteName, string url, bool status)
        {
           
            if (status==false)
            {
                extest = extentReports.CreateTest(siteName);
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                Screenshot_Test(siteName);
            }
        }

        public static void Screenshot_Test(string siteName)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var src = takesScreenshot.GetScreenshot();
           screenshotPath = path + siteName + TextContxt.TestName +""+".png";
            src.SaveAsFile(screenshotPath,ScreenshotImageFormat.Png);
            driver.Close();
        }


    }
}
