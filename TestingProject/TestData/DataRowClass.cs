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

namespace TestingProject.TestData
{
    [TestClass]
    [TestCategory("data_row")]
    public class DataRowClass
    {
        IWebDriver driver;
        ActiTimeLogin login;
        ActiTimeHome home;

        [TestMethod]
        [TestCategory("multi data")]
        [DataTestMethod]
        [DataRow("hello",true)]
        [DataRow("haii", false)]
        [DataRow("namaste", false)]
        public void Execute(String say, bool res)
        {
            Console.WriteLine(say);
            Assert.IsTrue(res);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("chrome")]
        [DataRow("IE")]
        public void CrossBrowserLogin(String browser)
        {
           // if(browser == chrome)
            {

            }
        }


        [TestMethod]
        [TestCategory("Multi login")]
        [DataTestMethod]
        [DataRow("admin","manager")]
       [DataRow("trainee","trainee")]
        public void MultiLogin_Test(string un,string pw)
        {
            driver = new ChromeDriver();
             login= new ActiTimeLogin(driver);
            home = new ActiTimeHome(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demo.actitime.com/login.do");
            login.Login(un,pw);
            
            home.click_logout();
            Thread.Sleep(3000);
            driver.Dispose();


        }


        
        [TestMethod]
        [TestCategory("Ignore")]
        [Ignore]
        public void Ignore_test()
        {
            Console.WriteLine("Ignore the execution");
        }


    }
}
