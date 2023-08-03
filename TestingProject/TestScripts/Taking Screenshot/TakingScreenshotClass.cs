using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.TestScripts.Taking_Screenshot
{
    [TestClass]
    [TestCategory("Screenshot")]
    public class TakingScreenshotClass
    {
        [TestMethod]
        public void Takes_Screenshot()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com");
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            var src=takesScreenshot.GetScreenshot();
          
            src.SaveAsFile("C:\\Users\\Admin\\source\\MyRepos\\TestingProject\\TestingProject\\screenshot\\test2.png", ScreenshotImageFormat.Png);


        }
    }
}
