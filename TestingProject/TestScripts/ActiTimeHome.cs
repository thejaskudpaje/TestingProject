using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.TestScripts
{
    [TestClass]
    public class ActiTimeHome : LoginToActiTimeUsingExcelData
    {
        public ActiTimeHome(IWebDriver driver1)
        {
        }



        //  public static object MessageBox { get; private set; }
        [TestMethod]
        [ClassInitialize]
        public  void ClassIni(TestContext context)
        {
            driver = new ChromeDriver();
            Uri url = new Uri("https://demo.actitime.com/login.do");
            driver.Navigate().GoToUrl(url);
        }

        [TestMethod]
        [ClassCleanup]
        public void ClassClose()
        {
            driver.Close();
        }

        [TestMethod]
        public void ActiTimeHome_Test()
        {
            Console.WriteLine("Welcome to actiTime home");
        }

    }
}
