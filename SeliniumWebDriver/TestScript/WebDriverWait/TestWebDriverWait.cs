using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeliniumWebDriver.ComponentHelper;
using SeliniumWebDriver.Settings;
using System;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SeliniumWebDriver.TestScript.DriverWait
{
    [TestClass]
    public class TestWebDriverWait
    {
        [TestMethod]
        public void TestWait()
        {
            NavigationHelper.NavigateToUrl("https://www.google.co.in/webhp");
            TextBoxHelper.TypeInTextBox(By.XPath("//textarea[@class = 'gLFyf']"), "C#");
        }
        //[TestMethod]
        //public void TestExpContidion()
        //{
        //    NavigationHelper.NavigateToUrl("https://www.udemy.com/");
        //    ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        //    WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(50));
        //    wait.PollingInterval = TimeSpan.FromMilliseconds(250);
        //    wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
        //    wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='q']"))).SendKeys("C#");
        //    ButtonHelper.ClickButton(By.XPath("//button[@type='submit']"));
        //    wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id=\"u430-popper-trigger--832\"]/div[2]/div[1]/div/h3/a"))).Click();
        //    Console.WriteLine("Title {0}", wait.Until(ExpectedConditions.TitleContains("u")));
        //    wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='desktop-header-module--gap-auth-button--f25sS'][1]"))).Click();
        //    wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"udemy\"]/div[1]/div[2]/div/div/main")));
        //}
    }
}
