using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.Handeling_PopUps
{
    [TestClass]
    [TestCategory("Handeling_PopUps")]
    public class AlertPopUp
    {
        [TestMethod]
        public void Alert_PopUp_Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            driver.FindElement(By.Id("alertButton")).Click();
            IAlert a = driver.SwitchTo().Alert();
            a.Accept();
            driver.Close();
        }
    }
}
