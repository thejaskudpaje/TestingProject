﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingProject.TestScripts
{

    [TestClass]
    
    [TestCategory("TimeOut")]
    public class TimeOut
    {

        [TestMethod]
        [Timeout(2000)]
        public void TimeOut_Test()
        {
            Thread.Sleep(3000);
        }
    }
}
