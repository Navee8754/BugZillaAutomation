using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeliniumWebDriver.Keyword_Driven_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.TestKeyword_Driven
{
    [TestClass]
    public class TestKeywordDriven
    {
        [TestMethod]
        public void TestKeyWord()
        {
            DataEngine dataEngine = new DataEngine();
            dataEngine.ExecuteScript(@"C:\Naveen\Automation\Specflow\Keyword Driven test.xlsx", "TC01");
        }
    }
}
