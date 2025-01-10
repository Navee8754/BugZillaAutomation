using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeliniumWebDriver.Settings;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SeliniumWebDriver.ComponentHelper
{
    public class Generichelper
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch
            { 
                return false;
            }
           
        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator)) 
                return ObjectRepository.Driver.FindElement(locator);
            else 
                throw new NoSuchElementException("Element Not Fount" +locator.ToString());
        }
      
        public static void TakeScreenShot(string filename = "Screen")
        {
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();

            if(filename.Equals("Screen"))
            {

                screen.SaveAsFile(filename);
                return;
            }
            screen.SaveAsFile(filename);
        }
        public static bool WaitForWebElement(By locator,TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new  WebDriverWait(ObjectRepository.Driver,timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            bool flag = wait.Until(WaitForWebElementFunc(locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            return flag;
        }
        public static IWebElement WaitForWebElementInPage(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            IWebElement flag = wait.Until(WaitForWebElementFuncInPageFunc(locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            return flag;
        }
        private static Func<IWebDriver, bool> WaitForWebElementFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return true;
                return false;
            });
        }

        private static Func<IWebDriver, IWebElement> WaitForWebElementFuncInPageFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1) 
                return x.FindElement(locator);
                return null;
            });
        }
    }
}
