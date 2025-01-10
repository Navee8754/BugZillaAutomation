using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void openpage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
           
        }
    }
}
