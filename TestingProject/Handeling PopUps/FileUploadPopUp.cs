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
    public class FileUploadPopUp
    {
        [TestMethod]
        public void File_Upload_PopUp_Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            string filePath = "";
        }
    }
}
