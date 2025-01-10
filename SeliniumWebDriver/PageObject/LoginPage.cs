using OpenQA.Selenium;
using SeliniumWebDriver.BaseClass;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.PageObject
{
    public class LoginPage : PageBase
    {

        private IWebDriver driver;

        #region Webelement

        private IWebElement LoginTextBox => ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
        private IWebElement PassTextBox => ObjectRepository.Driver.FindElement(By.Id("Bugzilla_password"));

        private IWebElement LoginBtn => ObjectRepository.Driver.FindElement(By.Id("log_in"));

        private IWebElement HomeLink => ObjectRepository.Driver.FindElement(By.Id("Home"));
        private IWebElement Title => ObjectRepository.Driver.FindElement(By.XPath("//td[@id=\"title\"]/p"));

       
        #endregion
        public LoginPage(IWebDriver _driver) : base(_driver) 
        { 
         this.driver = _driver;
        }
        #region Actions
        public BugDetailPage Login(string username, string password)
        {
            LoginTextBox.SendKeys(username);
            PassTextBox.SendKeys(password);
            LoginBtn.Click();
            return new BugDetailPage(driver);
        }
        #endregion
        public string GetPageTitle()
        {
            return Title.Text;
        }

        #region Navigation 
        public void navigateToHome()
        {
            HomeLink.Click();
        }
        #endregion
    }

}
