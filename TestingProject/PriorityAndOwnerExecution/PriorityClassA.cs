using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingProject.PriorityAndOwnerExecution
{
    [TestClass]
    [TestCategory("A")]
    public class PriorityClassA
    {

        [TestMethod] [Priority(1), TestCategory("smoke")]
        public void TM3()
        {
            Thread.Sleep(3000);
        }

        [TestMethod] [Priority(0), TestCategory("smoke")]
        public void TM1()
        {
            Thread.Sleep(3000);
        }

        [TestMethod]   [Priority(0)]  [TestCategory("Regression")]
        public void TM2()
        {
            Thread.Sleep(3000);
        }

        [TestMethod] [Priority(0)]
        public void TM4()
        {
            Thread.Sleep(3000);
        }

    }
}
