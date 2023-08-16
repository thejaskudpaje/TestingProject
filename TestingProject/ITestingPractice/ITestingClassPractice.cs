using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace TestingProject.ITestingPractice
{
    [TestClass]
    public class ITestingClassPractice
    {
        public ITestingClassPractice()
        {

        }
        public static TestContext testContext;

        public TestContext Text_Context
        {
            get { return testContext; }
            set { testContext = value; }

        }

    /*   [AssemblyInitialize]
        public static void method(TestContext _testContext)
        {
            testContext = _testContext;

        }
        [AssemblyCleanup]
        public static void Assembly_Clean_Test()
        {

        }*/
     /*   [TestInitialize]
        [TestCategory("TC")]
        public  void Initialize_Test()
        {
            Console.WriteLine("Test initializing");
            testContext.WriteLine(testContext.TestName);
        }
        [TestCleanup]
        public void cleanUp_Test()
        {

        }*/
        [TestMethod]
        [TestCategory("TC"),Owner("Thejas")]
        [Priority(1)]
        public void DataTesting()
        {
            if (Text_Context.Properties["Browser"].Equals("Chrome"))
            {
                IWebDriver driver=new ChromeDriver();
                Console.WriteLine("open chrome browser");
            }
            else
            {
                Assert.Fail("Invalid Browser");
            }
            Text_Context.WriteLine(Text_Context.TestName);
            Text_Context.WriteLine(Text_Context.Properties["Browser"].ToString());

        }

        [TestMethod]
        [TestCategory("TC"), Owner("Thejas")]
        [Priority(1)]
        public void DataTesting1()
        {
            Console.WriteLine(Text_Context.TestName);
            Console.WriteLine(Text_Context.Properties["Browser"]);
        }

        [TestInitialize]
        public void test_Initializing_block()
        {
            
            Console.WriteLine(Text_Context.TestName);
        }
        [TestCleanup]
        public void test_cleanUp_block()
        {

        }

    }
}
