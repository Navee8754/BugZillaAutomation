using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.HyperLink
{
    [TestClass]
    public class TesthyperLink
    {
        [TestMethod]
        public void clickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //IWebElement element = ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
            //element.Click();

            LinkHelper.ClickLink(By.LinkText("File a Bug"));
        }

    }
}
