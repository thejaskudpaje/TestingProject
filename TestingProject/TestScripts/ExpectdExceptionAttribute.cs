using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.TestScripts
{
    [TestClass]
    [TestCategory("ExpectdExceptionAttribute")]
    public class ExpectdExceptionAttribute
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SIOB_Exception_Test()
        {
            String[] a = { "a", "b", "c", "d" };
            for(int i=0; i<=a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
