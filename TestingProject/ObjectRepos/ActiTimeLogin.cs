using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.ObjectRepos
{
    [TestClass]
    public class ActiTimeLogin
    {
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement userNameTxtBx;

        [FindsBy(How = How.Name, Using = "pwd")]
        public IWebElement passwordTxtBx;

        [FindsBy(How = How.Id, Using = "loginButton")]
        public IWebElement submitBtn;

        public ActiTimeLogin(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void Login(String un,String pw)
        {
            userNameTxtBx.SendKeys(un);
            passwordTxtBx.SendKeys(pw);
            submitBtn.Click();  

        }
    }

   
}
