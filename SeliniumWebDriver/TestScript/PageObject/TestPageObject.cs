using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.PageObject;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.TestScript.PageObject
{
    [TestClass]
    public class TestPageObject
    {
        [TestMethod]
        public void Testpage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            LoginPage loginpage = homePage.NavigateToLogin();
           BugDetailPage bugDetailPage = loginpage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            bugDetailPage.SelectFromSeverity("normal");
        }
    }
}
