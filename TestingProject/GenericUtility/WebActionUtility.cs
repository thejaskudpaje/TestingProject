using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.BaseClass;

namespace TestingProject.GenericUtility
{
    
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    [TestCategory("WebActionUtility")]
    public class WebActionUtility : ActiTime
    {  
        [TestMethod]
        public void Implicit_Wait()
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
        }

    }
}
