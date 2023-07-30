using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.BaseClass;
using TestingProject.GenericUtility;
using TestingProject.ObjectRepos;

namespace TestingProject.TestScripts
{
    
    [TestClass]
    [TestCategory("actiTimeLoginusingexcel")]
    public class LoginToActiTimeUsingExcelData : ActiTime
    {
        WebActionUtility webAction=new WebActionUtility();
         ExcelUtility excelUtility=new ExcelUtility();   
        [TestMethod]
        public void LoginToActiTimeUsingExcel_Test()
        {

         string un=excelUtility.GetDataFromExcel("Sheet1", 1, 0);
         string pw = excelUtility.GetDataFromExcel("Sheet1", 1, 1);

            driver = new ChromeDriver();
            Uri url = new Uri("https://demo.actitime.com/login.do");
            driver.Navigate().GoToUrl(url);
            webAction.Implicit_Wait();
            ActiTimeLogin login = new ActiTimeLogin(driver);
            login.Login(un,pw);
            ActiTimeHome home = new ActiTimeHome(driver);
            home.click_logout();
            driver.Close();

            driver.Dispose();
        }
    }
}
