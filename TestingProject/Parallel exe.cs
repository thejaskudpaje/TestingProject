using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingProject
{
    
    public class Parallel_exe
    {
        [assembly: Parallelize(Workers =5, Scope =ExecutionScope.MethodLevel)]

        [TestClass]
        [TestCategory("parallelexecution")]
        public class Parallelexecution
        {
            [TestMethod]
            public void ParallelExecution1()
            {
                Thread.Sleep(2000);
                Console.WriteLine("TC_01");
            }

            [TestMethod]
            [DoNotParallelize]
            public void Parallelexecution2()
            {
                Thread.Sleep(2000);
                Console.WriteLine("do not parallize");
            }

            [TestMethod]
            public void ParallelExecution3()
            {
                Thread.Sleep(2000);
                Console.WriteLine("TC_03");
            }
        }
    }
}
