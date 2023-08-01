using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestingProject.GenericUtility
{
    [TestClass]
    public class AssemblyAtribute
    {
        [AssemblyInitialize]
        [TestMethod]
        public static void AssemblyIni(TestContext context)
        {
            MessageBox.Show("this is Assemblyinitialzer");
        }

        [AssemblyCleanup]
        [TestMethod]
        public static void Assemblycleanup()
        {
            MessageBox.Show("this is Assemblycleanup");
        }
    }
}
