using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestingProject.ObjectRepos;

namespace TestingProject.BaseClass
{
    [TestClass]
    public class ActiTime
    {
      public static IWebDriver driver;
        [TestMethod]
        [TestCategory("smoke")]
        [TestInitialize]
        public void Login_To_ActiTime_Test()
        { 
            driver=new ChromeDriver();
            Uri url= new Uri("https://demo.actitime.com/login.do");
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            ActiTimeLogin login=new ActiTimeLogin(driver);
            login.Login("admin","manager");  
        }
        [TestMethod]
        [TestCleanup]
        public void ActiTimeLogout_Test()
        {
            ActiTimeHome home = new ActiTimeHome(driver);
            home.click_logout();
            driver.Close();
        }
    }
}
