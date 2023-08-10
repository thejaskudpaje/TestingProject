using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        [TestInitialize]
        public void LoginToActiTimeUsingExcel_Test()
        {           
         string un=excelUtility.GetDataFromExcel("Sheet1", 1, 0);
         string pw = excelUtility.GetDataFromExcel("Sheet1", 1, 1);
            webAction.Implicit_Wait();
            ActiTimeLogin login = new ActiTimeLogin(driver);
            login.Login(un,pw);

        }
        [TestMethod]
        [TestCleanup]
        public void ActiTimeLogout_Test()
        {
        //    ActiTimeHome home = new ActiTimeHome(driver);
          //  home.ActiTimeLogout_Test();
          
        }

      
    }
}
