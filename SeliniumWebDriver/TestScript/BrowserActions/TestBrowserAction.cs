using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeliniumWebDriver.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript
{
    [TestClass]
    public class TestBrowserAction
    {
        [TestMethod]
        public void TestAction() 
        {
            NavigationHelper.NavigateToUrl("https://animesuge.to/");

        }
    }
}
