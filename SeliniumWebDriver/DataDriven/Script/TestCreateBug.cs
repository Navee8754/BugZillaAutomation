using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeliniumWebDriver.BaseClass;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.PageObject;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace SeliniumWebDriver.DataDriven.Script
{
    [TestClass]
    public class TestCreateBug
    {
        private TestContext testContext;
        public TestContext TestContext 
        { 
            get { return testContext; }
            set { testContext = value; }
        }


        [TestMethod]
        [DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=C:\Naveen\TestExceldata.xlsx;", "TestExceldata", DataAccessMethod.Sequential)]
        public void TestCreatebug()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homePage = new HomePage(ObjectRepository.Driver);
            LoginPage loginPage = homePage.NavigateToLogin();
            BugDetailPage bugDetailPage = loginPage.Login(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            bugDetailPage.SelectFromComboBox(TestContext.DataRow["Severity"].ToString(), TestContext.DataRow["Hardware"].ToString(), TestContext.DataRow["OS"].ToString());
            bugDetailPage.TypeIn(TestContext.DataRow["Summary"].ToString());
            bugDetailPage.ClickSubmit();
            bugDetailPage.ClickLogout();
        }
    }
}
