using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.ClassContext
{
    [TestClass]
    public class TestClassContext
    {
        private TestContext textcontext;

        public TestContext TestContext 
        { 
            get { return textcontext; } 
            set { textcontext = value; }
        }
        

        [TestMethod]
        public void Testcase1() 
        {
            Console.WriteLine("Test name {0}", TestContext.TestName);
        }
        [TestMethod]
        public void Testcase2()
        {
            Console.WriteLine("Test name {0}", TestContext.TestName);
        }

        [TestCleanup]
        public void Cleanup()
        { 
            Console.WriteLine("Test name {0}", TestContext.CurrentTestOutcome); 
        }
    }
}
