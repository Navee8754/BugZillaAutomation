using OpenQA.Selenium;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeliniumWebDriver.BaseClass
{
    public class PageBase
    {
        private IWebDriver driver;
        private IWebElement HomeLink => ObjectRepository.Driver.FindElement(By.Id("Home"));

        public PageBase(IWebDriver _driver)
        {
            this.driver = _driver;

        }

        public void Logout()
        {
            if (Generichelper.IsElementPresent(By.XPath("//div[@id=\"header\"]/ul[1]/li[11]/a"))) 
            {
                ButtonHelper.ClickButton(By.XPath("//div[@id=\"header\"]/ul[1]/li[11]/a"));
            }
        }

        protected void NavigateToHomePage()
        {
            HomeLink.Click();
        }
    }
}
