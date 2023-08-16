using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.ScreenShotDemo
{
    [TestClass]
    [TestCategory("ScreenshotDemo")]
    public class ScreenshotUsingCurrentTestOutcome
    {
       
        public static TestContext testContext;
        [ClassInitialize]
        public static void ClassInit(TestContext contxt)
        {
            testContext = contxt;
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
        }
        [TestInitialize]
        public void initialize_block()
        {

        }
        [TestCleanup]
        public void cleanup_block()
        {
            // Console.WriteLine(testContext.CurrentTestOutcome);
            if (testContext.CurrentTestOutcome.Equals(UnitTestOutcome.Passed))
            {
                Console.WriteLine("Test case pssed");
            }
            else if (testContext.CurrentTestOutcome.Equals(UnitTestOutcome.Failed))
            {
                ITakesScreenshot screenShot = new ChromeDriver();
                string path = "C:\\Users\\Admin\\source\\MyRepos\\TestingProject\\TestingProject\\ScreenShotDemo\\Screenshot\\" + testContext.TestName ;
              var sS= screenShot.GetScreenshot();
                sS.SaveAsFile (path,ScreenshotImageFormat.Png);

            }
            else {
                Console.WriteLine("Inpropper condition");
                    }
        }

        [TestMethod]
        public void Screenshot_Test01()
        {
            Console.WriteLine(testContext.CurrentTestOutcome);
            Assert.Fail();
        }

        [TestMethod]
        public void Screenshot_Test02()
        {

        }

    }
}
