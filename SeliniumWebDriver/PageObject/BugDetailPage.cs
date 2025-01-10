using OpenQA.Selenium;
using SeliniumWebDriver.BaseClass;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeliniumWebDriver.PageObject
{
    public class BugDetailPage : PageBase
    {
        private IWebDriver driver;

        #region Webelement
        private IWebElement SeverityDropDown => ObjectRepository.Driver.FindElement(By.Id("bug_severity"));
        private IWebElement HardwareDropDown => ObjectRepository.Driver.FindElement(By.Id("rep_platform"));
        private IWebElement OsDropDown => ObjectRepository.Driver.FindElement(By.Id("op_sys"));
        private IWebElement Summarytext => ObjectRepository.Driver.FindElement(By.Id("short_desc"));
        private IWebElement SubmitBug => ObjectRepository.Driver.FindElement(By.Id("commit"));
        private IWebElement LogoutDropDown => ObjectRepository.Driver.FindElement(By.XPath("//*[@id=\"header\"]/ul[1]/li[11]/a"));
        private IWebElement Title => ObjectRepository.Driver.FindElement(By.XPath("//td[@id='title']/p"));
        #endregion

        public BugDetailPage(IWebDriver _driver) : base(_driver) 
        {
            this.driver = _driver;
        }


        #region Actions 

        public void SelectFromSeverity(string value)
        {
            SeverityDropDown.SendKeys(value);
        }

        public void SelectFromComboBox(string severity, string hardware, string platform)
        {
            SeverityDropDown.SendKeys(severity);
            HardwareDropDown.SendKeys(hardware);
            OsDropDown.SendKeys(platform);
        }

        public void TypeIn(string summary)
        {
            Summarytext.SendKeys(summary);
        }

        public void ClickSubmit()
        {
            SubmitBug.Click();
        }
        #endregion
        public string GetPageTitle()
        {
            return Title.Text;
        }

        #region Navigation

        public void ClickLogout()
        {
          LogoutDropDown.Click();
        }

        #endregion
    }
}
