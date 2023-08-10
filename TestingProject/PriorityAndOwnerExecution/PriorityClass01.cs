using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.PriorityExecution
{
  //  [TestClass]
    [TestCategory("Priority classes")]
    public class PriorityClass01
    {
        [TestMethod]
        [TestCategory("Priority classes")]
        [Owner("thejas")]
        [Priority(1)]
        public void Test01()
        {
            Console.WriteLine("Priority(0)");
        }

        [TestMethod]
        [Owner("datta")]
        [Priority(2)]
        public void Test02()
        {
            Console.WriteLine("Priority(2)");
        }

    }

    [TestClass]
    [TestCategory("Priority classes")]
    public class PriorityClass02
    {
        [TestMethod]
        [Owner("datta")]
        [Priority(2)]
        public void Test03()
        {
            Console.WriteLine("Priority(2)");
        }

        [TestMethod]
        [Priority(1)]
        public void Test04()
        {
            Console.WriteLine("Priority(1)");
        }
    }

    [TestClass]
    [TestCategory("Priority classes")]
    public class PriorityClass03
    {
        [TestMethod]
        [Owner("thejas")]
        [Priority(-1)]
        public void Test05()
        {
            Console.WriteLine("Priority(-1)");
        }

        [TestMethod]
        [Owner("thejas")]
        [Priority(1)]
        public void Test06()
        {
            Console.WriteLine("Priority(1)");
        }
    }
}
