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
    public class HomePage : PageBase
    {
        private IWebDriver driver;

        #region Webelement
        private IWebElement QuickSearchtextbox => ObjectRepository.Driver.FindElement(By.Id("username"));

        private IWebElement QuicksearchBtn => ObjectRepository.Driver.FindElement(By.Id("find"));

        private IWebElement FileABugLink => ObjectRepository.Driver.FindElement(By.Id("enter_bug"));

        #endregion
       
        public HomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }
        
        #region Actions
        public void Quicksearch(string text)
        {
            QuickSearchtextbox.SendKeys(text);
            QuicksearchBtn.Click();
        }

        #endregion

        #region Navigation
        public LoginPage NavigateToLogin()
        {
            FileABugLink.Click();
            return new LoginPage(driver);
        }

        #endregion


    }
}
