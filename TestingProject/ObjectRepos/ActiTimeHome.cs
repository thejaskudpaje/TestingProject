using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.ObjectRepos
{
    /// <summary>
    /// Purpose of the class is to declare, initialize and utilize the elements present in the Acti Time home
    /// </summary>
    [TestClass]
    public class ActiTimeHome
    {
     
        // Locating the elements present in the home page
       
        [FindsBy(How = How.Id, Using = "container_tt")]
        private IWebElement time_track { get; set; }

        public IWebElement Time_Track
        {
            get { return time_track; }
            set { time_track = value; }
        }

        [FindsBy(How = How.Id, Using = "container_tasks")]
        private IWebElement tasks { get; set; }

        [FindsBy(How = How.Id, Using = "container_reports")]
         private IWebElement reports { get; set; }

        [FindsBy(How = How.Id, Using = "container_users")]
        private IWebElement users { get; set; }

        [FindsBy(How = How.Id, Using = "logoutLink")]
        private IWebElement logout { get; set; }

        //initializing the elements using Pagefactory 
        public ActiTimeHome(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //writing the buiseness logic
        public void click_Time_Track()
        {
            time_track.Click(); 
        }
   
        public void click_Tasks() {
            tasks.Click();
        }
    
        public void click_reports()
        {
            reports.Click();
        }

        public void click_users()
        {
            users.Click();
        }

        public void click_logout()
        {
            logout.Click();
        }

    }

    
}
