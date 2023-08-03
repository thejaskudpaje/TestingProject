using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.Handeling_PopUps
{
    [TestClass]
    [TestCategory("Handeling_PopUps")]
    public class HiddenDivisionPopUp
    {
        [TestMethod]
        public void Hidden_Division_Popup_Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("(//button)[2]")).Click();
            driver.Close();
        }
    }
}
